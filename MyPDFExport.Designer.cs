namespace LGSTrackingApp
{
    partial class MyPDFExport
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
            this.txtStudentExam = new System.Windows.Forms.TextBox();
            this.chkSelectedExam = new System.Windows.Forms.CheckBox();
            this.chkAllExams = new System.Windows.Forms.CheckBox();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.saveFileDialogS = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(334, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the exam name";
            // 
            // txtStudentExam
            // 
            this.txtStudentExam.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentExam.Location = new System.Drawing.Point(582, 179);
            this.txtStudentExam.Name = "txtStudentExam";
            this.txtStudentExam.Size = new System.Drawing.Size(257, 34);
            this.txtStudentExam.TabIndex = 1;
            // 
            // chkSelectedExam
            // 
            this.chkSelectedExam.AutoSize = true;
            this.chkSelectedExam.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSelectedExam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSelectedExam.Location = new System.Drawing.Point(450, 305);
            this.chkSelectedExam.Name = "chkSelectedExam";
            this.chkSelectedExam.Size = new System.Drawing.Size(308, 31);
            this.chkSelectedExam.TabIndex = 2;
            this.chkSelectedExam.Text = "Export Selected Exam Results";
            this.chkSelectedExam.UseVisualStyleBackColor = true;
            // 
            // chkAllExams
            // 
            this.chkAllExams.AutoSize = true;
            this.chkAllExams.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAllExams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAllExams.Location = new System.Drawing.Point(462, 384);
            this.chkAllExams.Name = "chkAllExams";
            this.chkAllExams.Size = new System.Drawing.Size(263, 31);
            this.chkAllExams.TabIndex = 3;
            this.chkAllExams.Text = "Export All Exam Results";
            this.chkAllExams.UseVisualStyleBackColor = true;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportPdf.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportPdf.Location = new System.Drawing.Point(894, 532);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(255, 85);
            this.btnExportPdf.TabIndex = 4;
            this.btnExportPdf.Text = "Export my Results as a PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // MyPDFExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1221, 755);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.chkAllExams);
            this.Controls.Add(this.chkSelectedExam);
            this.Controls.Add(this.txtStudentExam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyPDFExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My PDF Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentExam;
        private System.Windows.Forms.CheckBox chkSelectedExam;
        private System.Windows.Forms.CheckBox chkAllExams;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.SaveFileDialog saveFileDialogS;
    }
}