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
    public partial class frmDuyuruolusture : Form
    {
        public frmDuyuruolusture()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
           SqlCommand komut=new SqlCommand("select * from TBLDuyurular", bgl.baglanti());
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmDuyuruolusture_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDuyurular(ICERIK) values(@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rtbxDuyuru.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Duyuru oluşturuldu.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();

            listele();
        }

        string id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            rtbxDuyuru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text= id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBLDuyurular where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();

            MessageBox.Show("Duyuru silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            bgl.baglanti().Close();

            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLDuyurular set ICERIK=@p1 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rtbxDuyuru.Text);
            komut.Parameters.AddWithValue("@p2", id);
            komut.ExecuteNonQuery();

            MessageBox.Show("Duyuru güncellendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();

            listele(); 
        }
    }
}