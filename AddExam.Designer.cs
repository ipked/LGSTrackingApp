namespace LGSTrackingApp
{
    partial class AddExam
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
            this.btnExam = new System.Windows.Forms.Button();
            this.numDin = new System.Windows.Forms.NumericUpDown();
            this.numIng = new System.Windows.Forms.NumericUpDown();
            this.numInk = new System.Windows.Forms.NumericUpDown();
            this.numFen = new System.Windows.Forms.NumericUpDown();
            this.numTurk = new System.Windows.Forms.NumericUpDown();
            this.numMath = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numDinF = new System.Windows.Forms.NumericUpDown();
            this.numIngF = new System.Windows.Forms.NumericUpDown();
            this.numInkF = new System.Windows.Forms.NumericUpDown();
            this.numFenF = new System.Windows.Forms.NumericUpDown();
            this.numTurkF = new System.Windows.Forms.NumericUpDown();
            this.numMathF = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDinF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInkF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFenF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurkF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMathF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExam.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExam.Location = new System.Drawing.Point(538, 620);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(157, 47);
            this.btnExam.TabIndex = 77;
            this.btnExam.Text = "Add Exam";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // numDin
            // 
            this.numDin.Location = new System.Drawing.Point(386, 519);
            this.numDin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDin.Name = "numDin";
            this.numDin.Size = new System.Drawing.Size(120, 22);
            this.numDin.TabIndex = 76;
            // 
            // numIng
            // 
            this.numIng.Location = new System.Drawing.Point(386, 264);
            this.numIng.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIng.Name = "numIng";
            this.numIng.Size = new System.Drawing.Size(120, 22);
            this.numIng.TabIndex = 75;
            // 
            // numInk
            // 
            this.numInk.Location = new System.Drawing.Point(386, 383);
            this.numInk.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInk.Name = "numInk";
            this.numInk.Size = new System.Drawing.Size(120, 22);
            this.numInk.TabIndex = 74;
            // 
            // numFen
            // 
            this.numFen.Location = new System.Drawing.Point(55, 519);
            this.numFen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFen.Name = "numFen";
            this.numFen.Size = new System.Drawing.Size(120, 22);
            this.numFen.TabIndex = 73;
            // 
            // numTurk
            // 
            this.numTurk.Location = new System.Drawing.Point(55, 383);
            this.numTurk.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTurk.Name = "numTurk";
            this.numTurk.Size = new System.Drawing.Size(120, 22);
            this.numTurk.TabIndex = 72;
            // 
            // numMath
            // 
            this.numMath.Location = new System.Drawing.Point(55, 264);
            this.numMath.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMath.Name = "numMath";
            this.numMath.Size = new System.Drawing.Size(120, 22);
            this.numMath.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(388, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 70;
            this.label12.Text = "Inkılap Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(406, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "Ingilizce";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(388, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Din Kültürü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Türkçe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Fen Bilimleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Matematik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(851, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Exam Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(969, 48);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker.TabIndex = 63;
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(203, 45);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(196, 26);
            this.cmbStudents.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Choose Student";
            // 
            // numDinF
            // 
            this.numDinF.Location = new System.Drawing.Point(1045, 519);
            this.numDinF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDinF.Name = "numDinF";
            this.numDinF.Size = new System.Drawing.Size(120, 22);
            this.numDinF.TabIndex = 89;
            // 
            // numIngF
            // 
            this.numIngF.Location = new System.Drawing.Point(1045, 264);
            this.numIngF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIngF.Name = "numIngF";
            this.numIngF.Size = new System.Drawing.Size(120, 22);
            this.numIngF.TabIndex = 88;
            // 
            // numInkF
            // 
            this.numInkF.Location = new System.Drawing.Point(1045, 383);
            this.numInkF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInkF.Name = "numInkF";
            this.numInkF.Size = new System.Drawing.Size(120, 22);
            this.numInkF.TabIndex = 87;
            // 
            // numFenF
            // 
            this.numFenF.Location = new System.Drawing.Point(714, 519);
            this.numFenF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFenF.Name = "numFenF";
            this.numFenF.Size = new System.Drawing.Size(120, 22);
            this.numFenF.TabIndex = 86;
            // 
            // numTurkF
            // 
            this.numTurkF.Location = new System.Drawing.Point(714, 383);
            this.numTurkF.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTurkF.Name = "numTurkF";
            this.numTurkF.Size = new System.Drawing.Size(120, 22);
            this.numTurkF.TabIndex = 85;
            // 
            // numMathF
            // 
            this.numMathF.Location = new System.Drawing.Point(714, 264);
            this.numMathF.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMathF.Name = "numMathF";
            this.numMathF.Size = new System.Drawing.Size(120, 22);
            this.numMathF.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1047, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Inkılap Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1065, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Ingilizce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1047, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Din Kültürü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(737, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Türkçe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(711, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 18);
            this.label13.TabIndex = 79;
            this.label13.Text = "Fen Bilimleri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(725, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 18);
            this.label14.TabIndex = 78;
            this.label14.Text = "Matematik";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkCyan;
            this.label15.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(180, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 22);
            this.label15.TabIndex = 90;
            this.label15.Text = "Enter Correct Answers";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkCyan;
            this.label16.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(850, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 22);
            this.label16.TabIndex = 91;
            this.label16.Text = "Enter Wrong Answers";
            // 
            // txtExamName
            // 
            this.txtExamName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamName.Location = new System.Drawing.Point(584, 43);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(196, 27);
            this.txtExamName.TabIndex = 92;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(464, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 18);
            this.label17.TabIndex = 93;
            this.label17.Text = "Exam Name";
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1236, 726);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numDinF);
            this.Controls.Add(this.numIngF);
            this.Controls.Add(this.numInkF);
            this.Controls.Add(this.numFenF);
            this.Controls.Add(this.numTurkF);
            this.Controls.Add(this.numMathF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.numDin);
            this.Controls.Add(this.numIng);
            this.Controls.Add(this.numInk);
            this.Controls.Add(this.numFen);
            this.Controls.Add(this.numTurk);
            this.Controls.Add(this.numMath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Exam";
            ((System.ComponentModel.ISupportInitialize)(this.numDin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDinF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInkF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFenF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurkF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMathF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.NumericUpDown numDin;
        private System.Windows.Forms.NumericUpDown numIng;
        private System.Windows.Forms.NumericUpDown numInk;
        private System.Windows.Forms.NumericUpDown numFen;
        private System.Windows.Forms.NumericUpDown numTurk;
        private System.Windows.Forms.NumericUpDown numMath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDinF;
        private System.Windows.Forms.NumericUpDown numIngF;
        private System.Windows.Forms.NumericUpDown numInkF;
        private System.Windows.Forms.NumericUpDown numFenF;
        private System.Windows.Forms.NumericUpDown numTurkF;
        private System.Windows.Forms.NumericUpDown numMathF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label label17;
    }
}