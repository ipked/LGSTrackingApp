namespace LGSTrackingApp
{
    partial class ExamResults
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
            this.dataGridMyResults = new System.Windows.Forms.DataGridView();
            this.btnMyResults = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMyResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMyResults
            // 
            this.dataGridMyResults.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridMyResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMyResults.Location = new System.Drawing.Point(41, 176);
            this.dataGridMyResults.Name = "dataGridMyResults";
            this.dataGridMyResults.RowHeadersWidth = 51;
            this.dataGridMyResults.RowTemplate.Height = 24;
            this.dataGridMyResults.Size = new System.Drawing.Size(1107, 469);
            this.dataGridMyResults.TabIndex = 5;
            // 
            // btnMyResults
            // 
            this.btnMyResults.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMyResults.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyResults.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyResults.Location = new System.Drawing.Point(41, 131);
            this.btnMyResults.Name = "btnMyResults";
            this.btnMyResults.Size = new System.Drawing.Size(206, 39);
            this.btnMyResults.TabIndex = 4;
            this.btnMyResults.Text = "Load My Results";
            this.btnMyResults.UseVisualStyleBackColor = false;
            this.btnMyResults.Click += new System.EventHandler(this.btnMyResults_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(417, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Click the Button to See Your Exam Results";
            // 
            // ExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1227, 728);
            this.Controls.Add(this.dataGridMyResults);
            this.Controls.Add(this.btnMyResults);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExamResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Exam Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMyResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMyResults;
        private System.Windows.Forms.Button btnMyResults;
        private System.Windows.Forms.Label label10;
    }
}