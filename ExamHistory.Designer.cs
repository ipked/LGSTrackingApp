namespace LGSTrackingApp
{
    partial class ExamHistory
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
            this.cmbStudentList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudentList
            // 
            this.cmbStudentList.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentList.FormattingEnabled = true;
            this.cmbStudentList.Location = new System.Drawing.Point(177, 97);
            this.cmbStudentList.Name = "cmbStudentList";
            this.cmbStudentList.Size = new System.Drawing.Size(182, 26);
            this.cmbStudentList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Student";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShowAll.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAll.Location = new System.Drawing.Point(943, 185);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(241, 58);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All Exam Results";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShowSelected.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowSelected.Location = new System.Drawing.Point(40, 185);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(319, 58);
            this.btnShowSelected.TabIndex = 3;
            this.btnShowSelected.Text = "Show Selected Student\'s Exam Results";
            this.btnShowSelected.UseVisualStyleBackColor = false;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Location = new System.Drawing.Point(40, 258);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.RowHeadersWidth = 51;
            this.dataGridHistory.RowTemplate.Height = 24;
            this.dataGridHistory.Size = new System.Drawing.Size(1144, 437);
            this.dataGridHistory.TabIndex = 4;
            // 
            // ExamHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1215, 738);
            this.Controls.Add(this.dataGridHistory);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStudentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExamHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.DataGridView dataGridHistory;
    }
}