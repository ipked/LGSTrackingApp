using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace LGSTrackingApp
{
    public partial class PDFExport : Form
    {
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public PDFExport()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            cmbStudentPdf.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name + ' ' + Surname AS FullName FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbStudentPdf.Items.Add(new ComboBoxItem
                    {
                        Text = reader["FullName"].ToString(),
                        Value = (int)reader["StudentID"]
                    });
                }
            }

            if (cmbStudentPdf.Items.Count > 0)
                cmbStudentPdf.SelectedIndex = 0;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (cmbStudentPdf.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudentPdf.SelectedItem;
            int studentId = selectedStudent.Value;
            string studentName = selectedStudent.Text;

            bool exportSingle = checkSingleExam.Checked;
            bool exportAll = checkAllExams.Checked;

            if (!exportSingle && !exportAll)
            {
                MessageBox.Show("Please select at least one export option.");
                return;
            }

            if (exportSingle && string.IsNullOrWhiteSpace(textBoxExamN.Text))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF File";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string pdfPath = saveFileDialog.FileName;

            Document doc = new Document(PageSize.A4, 40f, 40f, 40f, 40f);
            PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph("Exam Report for: " + studentName, FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            List<string> examNames = new List<string>();
            Dictionary<string, List<double>> allNetValues = new Dictionary<string, List<double>>();
            string[] subjects = { "Matematik", "Türkçe", "FenBilimleri", "İngilizce", "İnkılapTarihi", "DinKültürü" };
            foreach (var subject in subjects)
                allNetValues[subject] = new List<double>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = exportSingle ?
                    "SELECT * FROM Exams WHERE StudentID = @StudentID AND ExamName = @ExamName" :
                    "SELECT * FROM Exams WHERE StudentID = @StudentID ORDER BY ExamDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                if (exportSingle)
                    cmd.Parameters.AddWithValue("@ExamName", textBoxExamN.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string examName = reader["ExamName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["ExamDate"]);

                    doc.Add(new Paragraph("Exam: " + examName + " (" + date.ToShortDateString() + ")", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.AddCell("Subject");
                    table.AddCell("Correct");
                    table.AddCell("Wrong");
                    table.AddCell("Net");

                    foreach (var subject in subjects)
                    {
                        table.AddCell(subject);
                        table.AddCell(reader[subject].ToString());
                        table.AddCell(reader[subject + "Wrong"].ToString());
                        double net = Convert.ToDouble(reader[subject + "Net"]);
                        table.AddCell(net.ToString("F1"));

                        if (exportAll)
                            allNetValues[subject].Add(net);
                    }

                    doc.Add(table);
                    doc.Add(new Paragraph("\n"));

                    if (exportSingle)
                    {
                        Chart chart = new Chart();
                        chart.Size = new Size(600, 300);
                        ChartArea area = new ChartArea();
                        chart.ChartAreas.Add(area);
                        Series series = new Series("Net")
                        {
                            ChartType = SeriesChartType.Column,
                            IsValueShownAsLabel = true
                        };
                        chart.Series.Add(series);

                        foreach (var subject in subjects)
                        {
                            double net = Convert.ToDouble(reader[subject + "Net"]);
                            series.Points.AddXY(subject, Math.Round(net, 1));
                        }

                        string chartPath = Path.Combine(Path.GetTempPath(), "chart.png");
                        chart.SaveImage(chartPath, ChartImageFormat.Png);

                        iTextSharp.text.Image chartImg = iTextSharp.text.Image.GetInstance(chartPath);
                        chartImg.ScaleToFit(500f, 250f);
                        chartImg.Alignment = Element.ALIGN_CENTER;
                        doc.Add(chartImg);
                        doc.NewPage();
                    }
                    else
                    {
                        examNames.Add(examName);
                    }
                }
                reader.Close();
            }

            if (exportAll && examNames.Count > 1)
            {
                Chart summaryChart = new Chart();
                summaryChart.Size = new Size(700, 400);
                summaryChart.ChartAreas.Add(new ChartArea("AllExams"));

                foreach (var subject in subjects)
                {
                    Series series = new Series(subject)
                    {
                        ChartType = SeriesChartType.Column,
                        BorderWidth = 2,
                        IsValueShownAsLabel = true
                    };
                    summaryChart.Series.Add(series);
                }

                for (int i = 0; i < examNames.Count; i++)
                {
                    foreach (var subject in subjects)
                    {
                        if (i < allNetValues[subject].Count)
                        {
                            summaryChart.Series[subject].Points.AddXY(examNames[i], Math.Round(allNetValues[subject][i], 1));
                        }
                    }
                }

                string summaryChartPath = Path.Combine(Path.GetTempPath(), "summary_chart.png");
                summaryChart.SaveImage(summaryChartPath, ChartImageFormat.Png);

                iTextSharp.text.Image summaryImg = iTextSharp.text.Image.GetInstance(summaryChartPath);
                summaryImg.ScaleToFit(500f, 300f);
                summaryImg.Alignment = Element.ALIGN_CENTER;
                doc.Add(new Paragraph("Summary Performance Chart", FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("\n"));
                doc.Add(summaryImg);
            }

            doc.Close();
            MessageBox.Show("PDF exported successfully.");
        }
    }
}
