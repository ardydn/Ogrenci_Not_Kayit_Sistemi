namespace OgrenciNotKayit2
{
    partial class frmOgrencınotsıstemı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrencınotsıstemı));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgretmenGırıs = new System.Windows.Forms.Button();
            this.txtOgretmenSıfre = new System.Windows.Forms.TextBox();
            this.lblOgretmensifree = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOgretmennumaraa = new System.Windows.Forms.Label();
            this.mskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOgrencıGırıs = new System.Windows.Forms.Button();
            this.txtOgrencıSıfre = new System.Windows.Forms.TextBox();
            this.lblOgrencisifree = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOgrencinumaraa = new System.Windows.Forms.Label();
            this.mskOgrencıNumara = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgretmenGırıs);
            this.groupBox1.Controls.Add(this.txtOgretmenSıfre);
            this.groupBox1.Controls.Add(this.lblOgretmensifree);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblOgretmennumaraa);
            this.groupBox1.Controls.Add(this.mskOgretmenNumara);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(406, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ögretmen Giriş";
            // 
            // btnOgretmenGırıs
            // 
            this.btnOgretmenGırıs.Location = new System.Drawing.Point(246, 105);
            this.btnOgretmenGırıs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOgretmenGırıs.Name = "btnOgretmenGırıs";
            this.btnOgretmenGırıs.Size = new System.Drawing.Size(150, 33);
            this.btnOgretmenGırıs.TabIndex = 2;
            this.btnOgretmenGırıs.Text = "Giriş Yap";
            this.btnOgretmenGırıs.UseVisualStyleBackColor = true;
            this.btnOgretmenGırıs.Click += new System.EventHandler(this.btnOgretmenGırıs_Click);
            // 
            // txtOgretmenSıfre
            // 
            this.txtOgretmenSıfre.Location = new System.Drawing.Point(246, 62);
            this.txtOgretmenSıfre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOgretmenSıfre.MaxLength = 4;
            this.txtOgretmenSıfre.Name = "txtOgretmenSıfre";
            this.txtOgretmenSıfre.Size = new System.Drawing.Size(148, 26);
            this.txtOgretmenSıfre.TabIndex = 1;
            this.txtOgretmenSıfre.UseSystemPasswordChar = true;
            // 
            // lblOgretmensifree
            // 
            this.lblOgretmensifree.AutoSize = true;
            this.lblOgretmensifree.Location = new System.Drawing.Point(167, 67);
            this.lblOgretmensifree.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOgretmensifree.Name = "lblOgretmensifree";
            this.lblOgretmensifree.Size = new System.Drawing.Size(40, 19);
            this.lblOgretmensifree.TabIndex = 2;
            this.lblOgretmensifree.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblOgretmennumaraa
            // 
            this.lblOgretmennumaraa.AutoSize = true;
            this.lblOgretmennumaraa.Location = new System.Drawing.Point(167, 29);
            this.lblOgretmennumaraa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOgretmennumaraa.Name = "lblOgretmennumaraa";
            this.lblOgretmennumaraa.Size = new System.Drawing.Size(61, 19);
            this.lblOgretmennumaraa.TabIndex = 1;
            this.lblOgretmennumaraa.Text = "Numara:";
            // 
            // mskOgretmenNumara
            // 
            this.mskOgretmenNumara.Location = new System.Drawing.Point(246, 24);
            this.mskOgretmenNumara.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mskOgretmenNumara.Mask = "0000";
            this.mskOgretmenNumara.Name = "mskOgretmenNumara";
            this.mskOgretmenNumara.Size = new System.Drawing.Size(148, 26);
            this.mskOgretmenNumara.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOgrencıGırıs);
            this.groupBox2.Controls.Add(this.txtOgrencıSıfre);
            this.groupBox2.Controls.Add(this.lblOgrencisifree);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblOgrencinumaraa);
            this.groupBox2.Controls.Add(this.mskOgrencıNumara);
            this.groupBox2.Location = new System.Drawing.Point(11, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(406, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ögrenci Giriş";
            // 
            // btnOgrencıGırıs
            // 
            this.btnOgrencıGırıs.Location = new System.Drawing.Point(246, 105);
            this.btnOgrencıGırıs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOgrencıGırıs.Name = "btnOgrencıGırıs";
            this.btnOgrencıGırıs.Size = new System.Drawing.Size(150, 33);
            this.btnOgrencıGırıs.TabIndex = 5;
            this.btnOgrencıGırıs.Text = "Giriş Yap";
            this.btnOgrencıGırıs.UseVisualStyleBackColor = true;
            this.btnOgrencıGırıs.Click += new System.EventHandler(this.btnOgrencıGırıs_Click);
            // 
            // txtOgrencıSıfre
            // 
            this.txtOgrencıSıfre.Location = new System.Drawing.Point(246, 62);
            this.txtOgrencıSıfre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOgrencıSıfre.Name = "txtOgrencıSıfre";
            this.txtOgrencıSıfre.Size = new System.Drawing.Size(148, 26);
            this.txtOgrencıSıfre.TabIndex = 4;
            this.txtOgrencıSıfre.UseSystemPasswordChar = true;
            // 
            // lblOgrencisifree
            // 
            this.lblOgrencisifree.AutoSize = true;
            this.lblOgrencisifree.Location = new System.Drawing.Point(167, 67);
            this.lblOgrencisifree.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOgrencisifree.Name = "lblOgrencisifree";
            this.lblOgrencisifree.Size = new System.Drawing.Size(40, 19);
            this.lblOgrencisifree.TabIndex = 2;
            this.lblOgrencisifree.Text = "Şifre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblOgrencinumaraa
            // 
            this.lblOgrencinumaraa.AutoSize = true;
            this.lblOgrencinumaraa.Location = new System.Drawing.Point(167, 29);
            this.lblOgrencinumaraa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOgrencinumaraa.Name = "lblOgrencinumaraa";
            this.lblOgrencinumaraa.Size = new System.Drawing.Size(61, 19);
            this.lblOgrencinumaraa.TabIndex = 1;
            this.lblOgrencinumaraa.Text = "Numara:";
            // 
            // mskOgrencıNumara
            // 
            this.mskOgrencıNumara.Location = new System.Drawing.Point(246, 24);
            this.mskOgrencıNumara.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mskOgrencıNumara.Mask = "0000";
            this.mskOgrencıNumara.Name = "mskOgrencıNumara";
            this.mskOgrencıNumara.Size = new System.Drawing.Size(148, 26);
            this.mskOgrencıNumara.TabIndex = 3;
            // 
            // frmOgrencınotsıstemı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(431, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmOgrencınotsıstemı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögrenci Not Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgretmenSıfre;
        private System.Windows.Forms.Label lblOgretmennumaraa;
        private System.Windows.Forms.MaskedTextBox mskOgretmenNumara;
        private System.Windows.Forms.Label lblOgretmensifree;
        private System.Windows.Forms.Button btnOgretmenGırıs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgrencıGırıs;
        private System.Windows.Forms.TextBox txtOgrencıSıfre;
        private System.Windows.Forms.Label lblOgrencisifree;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOgrencinumaraa;
        private System.Windows.Forms.MaskedTextBox mskOgrencıNumara;
    }
}

