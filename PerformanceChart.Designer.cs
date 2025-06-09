namespace LGSTrackingApp
{
    partial class PerformanceChart
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedExam = new System.Windows.Forms.TextBox();
            this.btnSelectedExam = new System.Windows.Forms.Button();
            this.btnAllExams = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.Location = new System.Drawing.Point(64, 238);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(452, 20);
            label2.TabIndex = 4;
            label2.Text = "Click the Button to See the Selected Exam\'s Performance Chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label3.Location = new System.Drawing.Point(64, 442);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(436, 20);
            label3.TabIndex = 5;
            label3.Text = "Click the Button to See Your All  Exams\' Performance Chart";
            // 
            // chartPerformance
            // 
            this.chartPerformance.BorderlineColor = System.Drawing.Color.MintCream;
            chartArea1.Name = "Main";
            this.chartPerformance.ChartAreas.Add(chartArea1);
            this.chartPerformance.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartPerformance.Legends.Add(legend1);
            this.chartPerformance.Location = new System.Drawing.Point(700, 0);
            this.chartPerformance.Name = "chartPerformance";
            this.chartPerformance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "Main";
            series1.Legend = "Legend1";
            series1.Name = "Net";
            this.chartPerformance.Series.Add(series1);
            this.chartPerformance.Size = new System.Drawing.Size(571, 724);
            this.chartPerformance.SuppressExceptions = true;
            this.chartPerformance.TabIndex = 0;
            this.chartPerformance.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(111, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Exam Name to see the Performance Chart";
            // 
            // txtSelectedExam
            // 
            this.txtSelectedExam.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedExam.Location = new System.Drawing.Point(158, 150);
            this.txtSelectedExam.Name = "txtSelectedExam";
            this.txtSelectedExam.Size = new System.Drawing.Size(265, 27);
            this.txtSelectedExam.TabIndex = 2;
            // 
            // btnSelectedExam
            // 
            this.btnSelectedExam.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSelectedExam.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedExam.Location = new System.Drawing.Point(115, 277);
            this.btnSelectedExam.Name = "btnSelectedExam";
            this.btnSelectedExam.Size = new System.Drawing.Size(327, 50);
            this.btnSelectedExam.TabIndex = 3;
            this.btnSelectedExam.Text = "Show My Selected Exam\'s Chart";
            this.btnSelectedExam.UseVisualStyleBackColor = false;
            this.btnSelectedExam.Click += new System.EventHandler(this.btnSelectedExam_Click);
            // 
            // btnAllExams
            // 
            this.btnAllExams.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAllExams.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllExams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllExams.Location = new System.Drawing.Point(115, 483);
            this.btnAllExams.Name = "btnAllExams";
            this.btnAllExams.Size = new System.Drawing.Size(327, 47);
            this.btnAllExams.TabIndex = 6;
            this.btnAllExams.Text = "Show My All Exams\' Chart";
            this.btnAllExams.UseVisualStyleBackColor = false;
            this.btnAllExams.Click += new System.EventHandler(this.btnAllExams_Click);
            // 
            // PerformanceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1271, 724);
            this.Controls.Add(this.btnAllExams);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnSelectedExam);
            this.Controls.Add(this.txtSelectedExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPerformance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PerformanceChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Performance Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedExam;
        private System.Windows.Forms.Button btnSelectedExam;
        private System.Windows.Forms.Button btnAllExams;
    }
}