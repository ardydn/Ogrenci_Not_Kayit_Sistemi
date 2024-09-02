using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayit2
{
    public partial class frmOgrencınotsıstemı : Form
    {
        public frmOgrencınotsıstemı()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        private void btnOgretmenGırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLOgretmen where NUMARA=@p1 and SIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtOgretmenSıfre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmOgretmen frm=new frmOgretmen();
                frm.numara = mskOgretmenNumara.Text;
                frm.Show();
                MessageBox.Show("Sisteme hoş geldiniz.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                if (mskOgretmenNumara != null && txtOgretmenSıfre != null)
                {
                    MessageBox.Show("Boş değer bıraktınız lütfen tekrar deneyin.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hatalı numara veya şifre girişi gerçekleşti.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bgl.baglanti().Close();
        }

        private void btnOgrencıGırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from TBLOgrenci where NUMARA=@p1 and SIFRE=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskOgrencıNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrencıSıfre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                frmOgrenci frm=new frmOgrenci();
                frm.numara = mskOgrencıNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                if (mskOgrencıNumara != null && txtOgrencıSıfre != null)
                {
                    MessageBox.Show("Boş değer bıraktınız lütfen tekrar deneyin.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hatalı numara veya şifre girişi gerçekleşti.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bgl.baglanti().Close();
        }

    }
}