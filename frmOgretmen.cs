using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayit2
{
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string numara;
        
        void ogrencilistesi()
        {
            SqlCommand komut = new SqlCommand("select * from TBLOgrenci ", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void notlistesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void frmOgretmen_Load(object sender, EventArgs e)
        {
            //Numarayı label aracına yazdırma
            lblOgrtnumara.Text = numara;

            //Numaraya göre isim bilgisi çekme
            SqlCommand komut=new SqlCommand("select * from TBLOgretmen where NUMARA=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lblOgrtad.Text = dr[1]+ " " + dr[2];
            }
            bgl.baglanti().Close();

            //Form loadda metod çekme.
            ogrencilistesi();

            //Form loadda 2. metod çekme.
            notlistesi();

        }

        string fotograf;

        private void btnFotografsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotograf= openFileDialog1.FileName;
            pictureBox1.ImageLocation = fotograf;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini kaydetme
            SqlCommand komut = new SqlCommand("Insert into TBLOgrenci(AD,SOYAD,NUMARA,SIFRE,FOTOGRAF) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskNumara.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", fotograf);
            komut.ExecuteNonQuery();

            MessageBox.Show("Öğrenci sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();

            ogrencilistesi();
            notlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLNotlar where OGRID=(select ID from TBLOgrenci where NUMARA=@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtSinav1.Text = dr[1].ToString();
                txtSinav2.Text = dr[2].ToString();
                txtSinav3.Text = dr[3].ToString();
                txtProje.Text = dr[4].ToString();
                txtOrtalama.Text = dr[5].ToString();
                txtDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini güncelleme
            SqlCommand komut = new SqlCommand("update TBLOgrenci set AD=@p1, SOYAD=@p2, SIFRE=@p3, FOTOGRAF=@p4 where NUMARA=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtSifre.Text);
            komut.Parameters.AddWithValue("@p4", fotograf);
            komut.Parameters.AddWithValue("@p5", mskNumara.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Öğrenci bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            bgl.baglanti().Close();

            //Öğrenci not bilgilerini güncelleme
            SqlCommand komut2 = new SqlCommand("update TBLNotlar set SINAV1=@p1, SINAV2=@p2, SINAV3=@p3, PROJE=@p4, ORTALAMA=@p5, DURUM=@p6 where OGRID=(select ID from TBLOgrenci where NUMARA=@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut2.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut2.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut2.Parameters.AddWithValue("@P4", txtProje.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", txtDurum.Text);
            komut2.Parameters.AddWithValue("@p7", mskNumara.Text);
            komut2.ExecuteNonQuery();

            MessageBox.Show("Öğrenci not bilgisi güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            bgl.baglanti().Close();

            ogrencilistesi();
            notlistesi();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1=Convert.ToDouble(txtSinav1.Text);
            sinav2=Convert.ToDouble(txtSinav2.Text);
            sinav3=Convert.ToDouble(txtSinav3.Text);
            proje=Convert.ToDouble(txtProje.Text);
            ortalama=(sinav1+sinav2+sinav3+proje)/4;
            txtOrtalama.Text=ortalama.ToString();
            if (ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnDuyuruolustur_Click(object sender, EventArgs e)
        {
            frmDuyuruolusture frm=new frmDuyuruolusture();
            frm.Show();
        }

        private void btnDuyurulistesi_Click(object sender, EventArgs e)
        {
            frmDuyurulistesi frm=new frmDuyurulistesi();
            frm.Show();
        }

        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            frmMesajlar frm=new frmMesajlar();
            frm.numara = lblOgrtnumara.Text;
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkış yapacak mısınız?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}