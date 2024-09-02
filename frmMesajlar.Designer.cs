namespace OgrenciNotKayit2
{
    partial class frmMesajlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesajlar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.rtbxMesaj = new System.Windows.Forms.RichTextBox();
            this.lblKonu = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.lblAlici = new System.Windows.Forms.Label();
            this.mskAlici = new System.Windows.Forms.MaskedTextBox();
            this.mskGonderen = new System.Windows.Forms.MaskedTextBox();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 113);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(426, 68);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gelen Kutusu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 62);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(426, 79);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giden Kutusu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 3);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(422, 73);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.lblMesaj);
            this.groupBox1.Controls.Add(this.rtbxMesaj);
            this.groupBox1.Controls.Add(this.lblKonu);
            this.groupBox1.Controls.Add(this.txtKonu);
            this.groupBox1.Controls.Add(this.lblAlici);
            this.groupBox1.Controls.Add(this.mskAlici);
            this.groupBox1.Controls.Add(this.mskGonderen);
            this.groupBox1.Controls.Add(this.lblGonderen);
            this.groupBox1.Location = new System.Drawing.Point(11, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(434, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(349, 20);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(83, 88);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(192, 23);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(58, 21);
            this.lblMesaj.TabIndex = 9;
            this.lblMesaj.Text = "Mesaj:";
            // 
            // rtbxMesaj
            // 
            this.rtbxMesaj.Location = new System.Drawing.Point(261, 20);
            this.rtbxMesaj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbxMesaj.Name = "rtbxMesaj";
            this.rtbxMesaj.Size = new System.Drawing.Size(84, 91);
            this.rtbxMesaj.TabIndex = 4;
            this.rtbxMesaj.Text = "";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(5, 85);
            this.lblKonu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(55, 21);
            this.lblKonu.TabIndex = 7;
            this.lblKonu.Text = "Konu:";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(104, 82);
            this.txtKonu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(84, 29);
            this.txtKonu.TabIndex = 3;
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(5, 54);
            this.lblAlici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(52, 21);
            this.lblAlici.TabIndex = 5;
            this.lblAlici.Text = "Alıcı:";
            // 
            // mskAlici
            // 
            this.mskAlici.Location = new System.Drawing.Point(104, 51);
            this.mskAlici.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskAlici.Mask = "0000";
            this.mskAlici.Name = "mskAlici";
            this.mskAlici.Size = new System.Drawing.Size(84, 29);
            this.mskAlici.TabIndex = 2;
            // 
            // mskGonderen
            // 
            this.mskGonderen.Location = new System.Drawing.Point(104, 20);
            this.mskGonderen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskGonderen.Mask = "0000";
            this.mskGonderen.Name = "mskGonderen";
            this.mskGonderen.Size = new System.Drawing.Size(84, 29);
            this.mskGonderen.TabIndex = 1;
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Location = new System.Drawing.Point(5, 23);
            this.lblGonderen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(88, 21);
            this.lblGonderen.TabIndex = 2;
            this.lblGonderen.Text = "Gönderen:";
            // 
            // frmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmMesajlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesajlar";
            this.Load += new System.EventHandler(this.frmMesajlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.RichTextBox rtbxMesaj;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.MaskedTextBox mskAlici;
        private System.Windows.Forms.MaskedTextBox mskGonderen;
        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}