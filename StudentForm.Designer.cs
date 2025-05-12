namespace LGSTrackingApp
{
    partial class StudentForm
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
            this.btnAddS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerExam = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numericDin = new System.Windows.Forms.NumericUpDown();
            this.numericInk = new System.Windows.Forms.NumericUpDown();
            this.numericIng = new System.Windows.Forms.NumericUpDown();
            this.numericFen = new System.Windows.Forms.NumericUpDown();
            this.numericTurk = new System.Windows.Forms.NumericUpDown();
            this.numericMath = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.examResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericDin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMath)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddS
            // 
            this.btnAddS.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddS.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddS.Location = new System.Drawing.Point(862, 557);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(171, 32);
            this.btnAddS.TabIndex = 33;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = false;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(776, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Click the button to add your new exam results.";
            // 
            // dateTimePickerExam
            // 
            this.dateTimePickerExam.Location = new System.Drawing.Point(168, 557);
            this.dateTimePickerExam.Name = "dateTimePickerExam";
            this.dateTimePickerExam.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExam.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(183, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Enter your exam date";
            // 
            // numericDin
            // 
            this.numericDin.Location = new System.Drawing.Point(995, 372);
            this.numericDin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDin.Name = "numericDin";
            this.numericDin.Size = new System.Drawing.Size(120, 22);
            this.numericDin.TabIndex = 29;
            // 
            // numericInk
            // 
            this.numericInk.Location = new System.Drawing.Point(675, 368);
            this.numericInk.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericInk.Name = "numericInk";
            this.numericInk.Size = new System.Drawing.Size(120, 22);
            this.numericInk.TabIndex = 28;
            // 
            // numericIng
            // 
            this.numericIng.Location = new System.Drawing.Point(995, 190);
            this.numericIng.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericIng.Name = "numericIng";
            this.numericIng.Size = new System.Drawing.Size(120, 22);
            this.numericIng.TabIndex = 27;
            // 
            // numericFen
            // 
            this.numericFen.Location = new System.Drawing.Point(675, 187);
            this.numericFen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericFen.Name = "numericFen";
            this.numericFen.Size = new System.Drawing.Size(120, 22);
            this.numericFen.TabIndex = 26;
            // 
            // numericTurk
            // 
            this.numericTurk.Location = new System.Drawing.Point(267, 364);
            this.numericTurk.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericTurk.Name = "numericTurk";
            this.numericTurk.Size = new System.Drawing.Size(120, 22);
            this.numericTurk.TabIndex = 25;
            // 
            // numericMath
            // 
            this.numericMath.Location = new System.Drawing.Point(267, 183);
            this.numericMath.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericMath.Name = "numericMath";
            this.numericMath.Size = new System.Drawing.Size(120, 22);
            this.numericMath.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(441, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Enter your correct answers for every subject. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(881, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Din Kültürü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(881, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ingilizce";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inkılap Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fen Bilimleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Matematik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // examResultsToolStripMenuItem
            // 
            this.examResultsToolStripMenuItem.Name = "examResultsToolStripMenuItem";
            this.examResultsToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.examResultsToolStripMenuItem.Text = "My Exam Results";
            this.examResultsToolStripMenuItem.Click += new System.EventHandler(this.examResultsToolStripMenuItem_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1238, 718);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerExam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericDin);
            this.Controls.Add(this.numericInk);
            this.Controls.Add(this.numericIng);
            this.Controls.Add(this.numericFen);
            this.Controls.Add(this.numericTurk);
            this.Controls.Add(this.numericMath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericDin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMath)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericDin;
        private System.Windows.Forms.NumericUpDown numericInk;
        private System.Windows.Forms.NumericUpDown numericIng;
        private System.Windows.Forms.NumericUpDown numericFen;
        private System.Windows.Forms.NumericUpDown numericTurk;
        private System.Windows.Forms.NumericUpDown numericMath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem examResultsToolStripMenuItem;
    }
}