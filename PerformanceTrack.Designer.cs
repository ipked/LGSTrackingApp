namespace LGSTrackingApp
{
    partial class PerformanceTrack
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPerformanceAdmin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudentsP = new System.Windows.Forms.ComboBox();
            this.txtBoxExamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectedExamA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAllExamsA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformanceAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPerformanceAdmin
            // 
            this.chartPerformanceAdmin.BorderlineColor = System.Drawing.Color.Honeydew;
            chartArea3.Name = "Main";
            this.chartPerformanceAdmin.ChartAreas.Add(chartArea3);
            this.chartPerformanceAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            legend3.Name = "Legend1";
            this.chartPerformanceAdmin.Legends.Add(legend3);
            this.chartPerformanceAdmin.Location = new System.Drawing.Point(703, 0);
            this.chartPerformanceAdmin.Name = "chartPerformanceAdmin";
            this.chartPerformanceAdmin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "Main";
            series3.Legend = "Legend1";
            series3.Name = "Net";
            this.chartPerformanceAdmin.Series.Add(series3);
            this.chartPerformanceAdmin.Size = new System.Drawing.Size(579, 755);
            this.chartPerformanceAdmin.TabIndex = 0;
            this.chartPerformanceAdmin.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Student";
            // 
            // cmbStudentsP
            // 
            this.cmbStudentsP.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentsP.FormattingEnabled = true;
            this.cmbStudentsP.Location = new System.Drawing.Point(196, 59);
            this.cmbStudentsP.Name = "cmbStudentsP";
            this.cmbStudentsP.Size = new System.Drawing.Size(176, 26);
            this.cmbStudentsP.TabIndex = 2;
            // 
            // txtBoxExamName
            // 
            this.txtBoxExamName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExamName.Location = new System.Drawing.Point(196, 148);
            this.txtBoxExamName.Name = "txtBoxExamName";
            this.txtBoxExamName.Size = new System.Drawing.Size(176, 27);
            this.txtBoxExamName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(39, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Exam Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(91, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Click the button to show Selected Exams\' Chart";
            // 
            // btnSelectedExamA
            // 
            this.btnSelectedExamA.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSelectedExamA.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedExamA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedExamA.Location = new System.Drawing.Point(95, 339);
            this.btnSelectedExamA.Name = "btnSelectedExamA";
            this.btnSelectedExamA.Size = new System.Drawing.Size(315, 41);
            this.btnSelectedExamA.TabIndex = 6;
            this.btnSelectedExamA.Text = "Show Selected Exam\'s Chart";
            this.btnSelectedExamA.UseVisualStyleBackColor = false;
            this.btnSelectedExamA.Click += new System.EventHandler(this.btnSelectedExam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(91, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click the button to show All Exams\' Chart";
            // 
            // btnAllExamsA
            // 
            this.btnAllExamsA.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAllExamsA.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllExamsA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllExamsA.Location = new System.Drawing.Point(95, 500);
            this.btnAllExamsA.Name = "btnAllExamsA";
            this.btnAllExamsA.Size = new System.Drawing.Size(315, 41);
            this.btnAllExamsA.TabIndex = 8;
            this.btnAllExamsA.Text = "Show All Exams\' Chart";
            this.btnAllExamsA.UseVisualStyleBackColor = false;
            this.btnAllExamsA.Click += new System.EventHandler(this.btnAllExamsA_Click);
            // 
            // PerformanceTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1282, 755);
            this.Controls.Add(this.btnAllExamsA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelectedExamA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxExamName);
            this.Controls.Add(this.cmbStudentsP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPerformanceAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PerformanceTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Track";
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformanceAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformanceAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudentsP;
        private System.Windows.Forms.TextBox txtBoxExamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectedExamA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAllExamsA;
    }
}