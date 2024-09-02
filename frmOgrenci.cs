using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciNotKayit2
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        public string numara;

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            //Numaraya göre isim bilgisini çekme

            SqlCommand komut = new SqlCommand("select * from TBLOgrenci where NUMARA=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblOgrenciad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }

            //Not listesini çekme

            SqlCommand komut2 = new SqlCommand("select * from TBLNotlar where OGRID=(select ID from TBLOgrenci where NUMARA=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", lblNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblSinav1.Text = dr2[1].ToString();
                lblSinav2.Text = dr2[2].ToString();
                lblSinav3.Text = dr2[3].ToString();
                lblProje.Text = dr2[4].ToString();
                lblOrtalama.Text = dr2[5].ToString();
            }

            bgl.baglanti().Close();

            if (Convert.ToDouble(lblOrtalama.Text) >= 50)
            {
                lblDurum.Text = "Geçti";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "Kaldı";
                lblDurum.ForeColor = Color.Red;
            }
        }

        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            frmMesajlar frm=new frmMesajlar();
            frm.numara = lblNumara.Text;
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurulistesi frm=new frmDuyurulistesi();
            frm.Show();
        }

        private void btnHesapmakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkış yapılsın mı?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}