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
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        public string numara;

        void gelenmesajlar()
        {
            SqlCommand komut = new SqlCommand("select * from TBLMesajlar where ALICI=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        void gidenmesajlar()
        {
            SqlCommand komut = new SqlCommand("select * from TBLMesajlar where GONDEREN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            mskGonderen.Text = numara;

            gelenmesajlar();
            gidenmesajlar();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLMesajlar(GONDEREN,ALICI,BASLIK,ICERIK) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskGonderen.Text);
            komut.Parameters.AddWithValue("@p2", mskAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtKonu.Text);
            komut.Parameters.AddWithValue("@p4", rtbxMesaj.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Mesajınız iletildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();

            gelenmesajlar();
            gidenmesajlar();
        }
    }
}