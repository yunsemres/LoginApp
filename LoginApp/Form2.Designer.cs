namespace LoginApp
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdnErkek = new System.Windows.Forms.RadioButton();
            this.rdnKadin = new System.Windows.Forms.RadioButton();
            this.chckEvli = new System.Windows.Forms.CheckBox();
            this.chckBekar = new System.Windows.Forms.CheckBox();
            this.btnKoltukSecimi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.txtKalanKoltuk = new System.Windows.Forms.TextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btnKoltukSecimi);
            this.groupBox1.Controls.Add(this.chckBekar);
            this.groupBox1.Controls.Add(this.chckEvli);
            this.groupBox1.Controls.Add(this.rdnKadin);
            this.groupBox1.Controls.Add(this.rdnErkek);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoyAd);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen Bilgilerinizi Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SoyAd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(65, 26);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(65, 58);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Location = new System.Drawing.Point(65, 87);
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.Size = new System.Drawing.Size(100, 20);
            this.txtSoyAd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Medeni Hal";
            // 
            // rdnErkek
            // 
            this.rdnErkek.AutoSize = true;
            this.rdnErkek.Location = new System.Drawing.Point(18, 165);
            this.rdnErkek.Name = "rdnErkek";
            this.rdnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdnErkek.TabIndex = 10;
            this.rdnErkek.TabStop = true;
            this.rdnErkek.Text = "Erkek";
            this.rdnErkek.UseVisualStyleBackColor = true;
            // 
            // rdnKadin
            // 
            this.rdnKadin.AutoSize = true;
            this.rdnKadin.Location = new System.Drawing.Point(19, 188);
            this.rdnKadin.Name = "rdnKadin";
            this.rdnKadin.Size = new System.Drawing.Size(52, 17);
            this.rdnKadin.TabIndex = 11;
            this.rdnKadin.TabStop = true;
            this.rdnKadin.Text = "Kadın";
            this.rdnKadin.UseVisualStyleBackColor = true;
            // 
            // chckEvli
            // 
            this.chckEvli.AutoSize = true;
            this.chckEvli.Location = new System.Drawing.Point(107, 165);
            this.chckEvli.Name = "chckEvli";
            this.chckEvli.Size = new System.Drawing.Size(43, 17);
            this.chckEvli.TabIndex = 12;
            this.chckEvli.Text = "Evli";
            this.chckEvli.UseVisualStyleBackColor = true;
            // 
            // chckBekar
            // 
            this.chckBekar.AutoSize = true;
            this.chckBekar.Location = new System.Drawing.Point(107, 188);
            this.chckBekar.Name = "chckBekar";
            this.chckBekar.Size = new System.Drawing.Size(54, 17);
            this.chckBekar.TabIndex = 13;
            this.chckBekar.Text = "Bekar";
            this.chckBekar.UseVisualStyleBackColor = true;
            // 
            // btnKoltukSecimi
            // 
            this.btnKoltukSecimi.Location = new System.Drawing.Point(17, 220);
            this.btnKoltukSecimi.Name = "btnKoltukSecimi";
            this.btnKoltukSecimi.Size = new System.Drawing.Size(144, 23);
            this.btnKoltukSecimi.TabIndex = 14;
            this.btnKoltukSecimi.Text = "Mevcut Koltukları Gör";
            this.btnKoltukSecimi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIslem);
            this.groupBox2.Controls.Add(this.txtKalanKoltuk);
            this.groupBox2.Controls.Add(this.txtKapasite);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satın Alma İşlemleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Otobüsün Kapasitesi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kalan Koltuk Sayısı:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(117, 29);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(48, 20);
            this.txtTutar.TabIndex = 18;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(117, 60);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(48, 20);
            this.txtKapasite.TabIndex = 19;
            // 
            // txtKalanKoltuk
            // 
            this.txtKalanKoltuk.Location = new System.Drawing.Point(117, 89);
            this.txtKalanKoltuk.Name = "txtKalanKoltuk";
            this.txtKalanKoltuk.Size = new System.Drawing.Size(48, 20);
            this.txtKalanKoltuk.TabIndex = 20;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(107, 115);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(58, 24);
            this.btnIslem.TabIndex = 21;
            this.btnIslem.Text = "Satın Al";
            this.btnIslem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(261, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koltuk Seçimi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 113);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnKoltukSecimi;
        private System.Windows.Forms.CheckBox chckBekar;
        private System.Windows.Forms.CheckBox chckEvli;
        private System.Windows.Forms.RadioButton rdnKadin;
        private System.Windows.Forms.RadioButton rdnErkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.TextBox txtKalanKoltuk;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}