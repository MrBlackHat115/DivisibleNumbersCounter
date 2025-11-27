namespace Firstapplication
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDivisibleTerm = new System.Windows.Forms.ComboBox();
            this.txtDivisibleNumbers = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.GroupBox();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // txtStartFrom
            // 
            this.txtStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartFrom.Location = new System.Drawing.Point(231, 69);
            this.txtStartFrom.Name = "txtStartFrom";
            this.txtStartFrom.Size = new System.Drawing.Size(100, 26);
            this.txtStartFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(406, 69);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 26);
            this.txtTo.TabIndex = 3;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(231, 199);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 41);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(406, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Divisible Number";
            // 
            // cmbDivisibleTerm
            // 
            this.cmbDivisibleTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivisibleTerm.FormattingEnabled = true;
            this.cmbDivisibleTerm.Location = new System.Drawing.Point(300, 135);
            this.cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            this.cmbDivisibleTerm.Size = new System.Drawing.Size(121, 28);
            this.cmbDivisibleTerm.TabIndex = 7;
            this.cmbDivisibleTerm.SelectedIndexChanged += new System.EventHandler(this.cmbDivisibleTerm_SelectedIndexChanged);
            // 
            // txtDivisibleNumbers
            // 
            this.txtDivisibleNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisibleNumbers.Location = new System.Drawing.Point(-1, 255);
            this.txtDivisibleNumbers.Multiline = true;
            this.txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            this.txtDivisibleNumbers.Size = new System.Drawing.Size(761, 139);
            this.txtDivisibleNumbers.TabIndex = 8;
            // 
            // Color
            // 
            this.Color.Controls.Add(this.rbGreen);
            this.Color.Controls.Add(this.rbBlue);
            this.Color.Controls.Add(this.rbRed);
            this.Color.Controls.Add(this.rbBlack);
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(549, 69);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(200, 171);
            this.Color.TabIndex = 9;
            this.Color.TabStop = false;
            this.Color.Text = "Select Color:";
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(7, 130);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(72, 24);
            this.rbGreen.TabIndex = 10;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(7, 100);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(59, 24);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(7, 70);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(57, 24);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(7, 37);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(66, 24);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(40, 175);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 24);
            this.chkBold.TabIndex = 10;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(40, 216);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(61, 24);
            this.chkItalic.TabIndex = 11;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 391);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.txtDivisibleNumbers);
            this.Controls.Add(this.cmbDivisibleTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtStartFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Counting Numbers";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Color.ResumeLayout(false);
            this.Color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDivisibleTerm;
        private System.Windows.Forms.TextBox txtDivisibleNumbers;
        private System.Windows.Forms.GroupBox Color;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
    }
}

