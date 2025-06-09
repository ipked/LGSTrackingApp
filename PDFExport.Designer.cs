namespace LGSTrackingApp
{
    partial class PDFExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudentPdf = new System.Windows.Forms.ComboBox();
            this.checkSingleExam = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExamN = new System.Windows.Forms.TextBox();
            this.checkAllExams = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialogA = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Student";
            // 
            // cmbStudentPdf
            // 
            this.cmbStudentPdf.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentPdf.FormattingEnabled = true;
            this.cmbStudentPdf.Location = new System.Drawing.Point(84, 206);
            this.cmbStudentPdf.Name = "cmbStudentPdf";
            this.cmbStudentPdf.Size = new System.Drawing.Size(200, 26);
            this.cmbStudentPdf.TabIndex = 1;
            // 
            // checkSingleExam
            // 
            this.checkSingleExam.AutoSize = true;
            this.checkSingleExam.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSingleExam.Location = new System.Drawing.Point(745, 323);
            this.checkSingleExam.Name = "checkSingleExam";
            this.checkSingleExam.Size = new System.Drawing.Size(242, 24);
            this.checkSingleExam.TabIndex = 2;
            this.checkSingleExam.Text = "Export Selected Exam Results";
            this.checkSingleExam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(952, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a exam name";
            // 
            // textBoxExamN
            // 
            this.textBoxExamN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamN.Location = new System.Drawing.Point(926, 205);
            this.textBoxExamN.Name = "textBoxExamN";
            this.textBoxExamN.Size = new System.Drawing.Size(200, 27);
            this.textBoxExamN.TabIndex = 4;
            // 
            // checkAllExams
            // 
            this.checkAllExams.AutoSize = true;
            this.checkAllExams.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAllExams.Location = new System.Drawing.Point(258, 323);
            this.checkAllExams.Name = "checkAllExams";
            this.checkAllExams.Size = new System.Drawing.Size(208, 24);
            this.checkAllExams.TabIndex = 5;
            this.checkAllExams.Text = "Export All Exam Results";
            this.checkAllExams.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(481, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // PDFExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1247, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkAllExams);
            this.Controls.Add(this.textBoxExamN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkSingleExam);
            this.Controls.Add(this.cmbStudentPdf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PDFExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudentPdf;
        private System.Windows.Forms.CheckBox checkSingleExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExamN;
        private System.Windows.Forms.CheckBox checkAllExams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogA;
    }
}