
namespace WindowsFormsApp19
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
            this.OilCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MoneyBox = new System.Windows.Forms.MaskedTextBox();
            this.LiterBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LiterBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentH = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.hdpr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fpp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ccp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HDBox = new System.Windows.Forms.MaskedTextBox();
            this.icp = new System.Windows.Forms.Label();
            this.FPBox = new System.Windows.Forms.MaskedTextBox();
            this.CCBox = new System.Windows.Forms.MaskedTextBox();
            this.İCBox = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxFp = new System.Windows.Forms.CheckBox();
            this.checkBoxCC = new System.Windows.Forms.CheckBox();
            this.checkBoxIC = new System.Windows.Forms.CheckBox();
            this.checkBoxHD = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OilCombo
            // 
            this.OilCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilCombo.FormattingEnabled = true;
            this.OilCombo.Location = new System.Drawing.Point(92, 21);
            this.OilCombo.Name = "OilCombo";
            this.OilCombo.Size = new System.Drawing.Size(146, 39);
            this.OilCombo.TabIndex = 0;
            this.OilCombo.SelectedIndexChanged += new System.EventHandler(this.OilCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MoneyBox);
            this.groupBox1.Controls.Add(this.LiterBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.LiterBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OilCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Enabled = false;
            this.MoneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBox.Location = new System.Drawing.Point(215, 198);
            this.MoneyBox.Mask = "00000";
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(149, 38);
            this.MoneyBox.TabIndex = 8;
            this.MoneyBox.ValidatingType = typeof(int);
            // 
            // LiterBox
            // 
            this.LiterBox.Enabled = false;
            this.LiterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiterBox.Location = new System.Drawing.Point(215, 146);
            this.LiterBox.Mask = "00000";
            this.LiterBox.Name = "LiterBox";
            this.LiterBox.Size = new System.Drawing.Size(149, 38);
            this.LiterBox.TabIndex = 7;
            this.LiterBox.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Location = new System.Drawing.Point(6, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "azn";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(132, 31);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(42, 44);
            this.Total.TabIndex = 6;
            this.Total.Text = "0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(31, 198);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 36);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Money";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LiterBtn
            // 
            this.LiterBtn.AutoSize = true;
            this.LiterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiterBtn.Location = new System.Drawing.Point(31, 146);
            this.LiterBtn.Name = "LiterBtn";
            this.LiterBtn.Size = new System.Drawing.Size(92, 36);
            this.LiterBtn.TabIndex = 2;
            this.LiterBtn.TabStop = true;
            this.LiterBtn.Text = "Liter";
            this.LiterBtn.UseVisualStyleBackColor = true;
            this.LiterBtn.CheckedChanged += new System.EventHandler(this.LiterBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "azn";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(120, 70);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(32, 36);
            this.Price.TabIndex = 3;
            this.Price.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oil";
            // 
            // PaymentH
            // 
            this.PaymentH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentH.FormattingEnabled = true;
            this.PaymentH.ItemHeight = 31;
            this.PaymentH.Location = new System.Drawing.Point(18, 441);
            this.PaymentH.Name = "PaymentH";
            this.PaymentH.Size = new System.Drawing.Size(865, 190);
            this.PaymentH.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.hdpr);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.fpp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ccp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.HDBox);
            this.groupBox3.Controls.Add(this.icp);
            this.groupBox3.Controls.Add(this.FPBox);
            this.groupBox3.Controls.Add(this.CCBox);
            this.groupBox3.Controls.Add(this.İCBox);
            this.groupBox3.Controls.Add(this.checkBoxFp);
            this.groupBox3.Controls.Add(this.checkBoxCC);
            this.groupBox3.Controls.Add(this.checkBoxIC);
            this.groupBox3.Controls.Add(this.checkBoxHD);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 351);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(228, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "azn";
            // 
            // hdpr
            // 
            this.hdpr.AutoSize = true;
            this.hdpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdpr.Location = new System.Drawing.Point(165, 40);
            this.hdpr.Name = "hdpr";
            this.hdpr.Size = new System.Drawing.Size(57, 36);
            this.hdpr.TabIndex = 17;
            this.hdpr.Text = "2.5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "azn";
            // 
            // fpp
            // 
            this.fpp.AutoSize = true;
            this.fpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpp.Location = new System.Drawing.Point(190, 95);
            this.fpp.Name = "fpp";
            this.fpp.Size = new System.Drawing.Size(32, 36);
            this.fpp.TabIndex = 15;
            this.fpp.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "azn";
            // 
            // ccp
            // 
            this.ccp.AutoSize = true;
            this.ccp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccp.Location = new System.Drawing.Point(172, 146);
            this.ccp.Name = "ccp";
            this.ccp.Size = new System.Drawing.Size(57, 36);
            this.ccp.TabIndex = 13;
            this.ccp.Text = "1.4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "azn";
            // 
            // HDBox
            // 
            this.HDBox.Enabled = false;
            this.HDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDBox.Location = new System.Drawing.Point(307, 38);
            this.HDBox.Mask = "00000";
            this.HDBox.Name = "HDBox";
            this.HDBox.Size = new System.Drawing.Size(105, 38);
            this.HDBox.TabIndex = 9;
            this.HDBox.ValidatingType = typeof(int);
            // 
            // icp
            // 
            this.icp.AutoSize = true;
            this.icp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icp.Location = new System.Drawing.Point(172, 200);
            this.icp.Name = "icp";
            this.icp.Size = new System.Drawing.Size(57, 36);
            this.icp.TabIndex = 9;
            this.icp.Text = "0.7";
            // 
            // FPBox
            // 
            this.FPBox.Enabled = false;
            this.FPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPBox.Location = new System.Drawing.Point(307, 93);
            this.FPBox.Mask = "00000";
            this.FPBox.Name = "FPBox";
            this.FPBox.Size = new System.Drawing.Size(105, 38);
            this.FPBox.TabIndex = 10;
            this.FPBox.ValidatingType = typeof(int);
            // 
            // CCBox
            // 
            this.CCBox.Enabled = false;
            this.CCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCBox.Location = new System.Drawing.Point(307, 144);
            this.CCBox.Mask = "00000";
            this.CCBox.Name = "CCBox";
            this.CCBox.Size = new System.Drawing.Size(105, 38);
            this.CCBox.TabIndex = 11;
            this.CCBox.ValidatingType = typeof(int);
            // 
            // İCBox
            // 
            this.İCBox.Enabled = false;
            this.İCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.İCBox.Location = new System.Drawing.Point(307, 196);
            this.İCBox.Mask = "00000";
            this.İCBox.Name = "İCBox";
            this.İCBox.Size = new System.Drawing.Size(105, 38);
            this.İCBox.TabIndex = 12;
            this.İCBox.ValidatingType = typeof(int);
            // 
            // checkBoxFp
            // 
            this.checkBoxFp.AutoSize = true;
            this.checkBoxFp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFp.Location = new System.Drawing.Point(17, 98);
            this.checkBoxFp.Name = "checkBoxFp";
            this.checkBoxFp.Size = new System.Drawing.Size(167, 33);
            this.checkBoxFp.TabIndex = 6;
            this.checkBoxFp.Text = "Fried Potato";
            this.checkBoxFp.UseVisualStyleBackColor = true;
            this.checkBoxFp.CheckedChanged += new System.EventHandler(this.FP_CheckedChanged);
            // 
            // checkBoxCC
            // 
            this.checkBoxCC.AutoSize = true;
            this.checkBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCC.Location = new System.Drawing.Point(17, 151);
            this.checkBoxCC.Name = "checkBoxCC";
            this.checkBoxCC.Size = new System.Drawing.Size(149, 33);
            this.checkBoxCC.TabIndex = 5;
            this.checkBoxCC.Text = "Coca-Cola";
            this.checkBoxCC.UseVisualStyleBackColor = true;
            this.checkBoxCC.CheckedChanged += new System.EventHandler(this.CC_CheckedChanged);
            // 
            // checkBoxIC
            // 
            this.checkBoxIC.AutoSize = true;
            this.checkBoxIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIC.Location = new System.Drawing.Point(17, 203);
            this.checkBoxIC.Name = "checkBoxIC";
            this.checkBoxIC.Size = new System.Drawing.Size(140, 33);
            this.checkBoxIC.TabIndex = 4;
            this.checkBoxIC.Text = "Ice cream";
            this.checkBoxIC.UseVisualStyleBackColor = true;
            this.checkBoxIC.CheckedChanged += new System.EventHandler(this.İC_CheckedChanged);
            // 
            // checkBoxHD
            // 
            this.checkBoxHD.AutoSize = true;
            this.checkBoxHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHD.Location = new System.Drawing.Point(17, 43);
            this.checkBoxHD.Name = "checkBoxHD";
            this.checkBoxHD.Size = new System.Drawing.Size(117, 33);
            this.checkBoxHD.TabIndex = 3;
            this.checkBoxHD.Text = "HotDog";
            this.checkBoxHD.UseVisualStyleBackColor = true;
            this.checkBoxHD.CheckedChanged += new System.EventHandler(this.HD_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Total2);
            this.groupBox4.Location = new System.Drawing.Point(6, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 94);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "azn";
            // 
            // Total2
            // 
            this.Total2.AutoSize = true;
            this.Total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total2.Location = new System.Drawing.Point(118, 31);
            this.Total2.Name = "Total2";
            this.Total2.Size = new System.Drawing.Size(42, 44);
            this.Total2.TabIndex = 6;
            this.Total2.Text = "0";
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(236, 381);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(441, 42);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.AutoSize = true;
            this.Loadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(227, 651);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(441, 42);
            this.Loadbtn.TabIndex = 8;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 705);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PaymentH);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OilCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton LiterBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MoneyBox;
        private System.Windows.Forms.MaskedTextBox LiterBox;
        private System.Windows.Forms.ListBox PaymentH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label hdpr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fpp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ccp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox HDBox;
        private System.Windows.Forms.Label icp;
        private System.Windows.Forms.MaskedTextBox FPBox;
        private System.Windows.Forms.MaskedTextBox CCBox;
        private System.Windows.Forms.MaskedTextBox İCBox;
        private System.Windows.Forms.CheckBox checkBoxFp;
        private System.Windows.Forms.CheckBox checkBoxCC;
        private System.Windows.Forms.CheckBox checkBoxIC;
        private System.Windows.Forms.CheckBox checkBoxHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Loadbtn;
    }
}

