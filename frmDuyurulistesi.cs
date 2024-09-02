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
    public partial class frmDuyurulistesi : Form
    {
        public frmDuyurulistesi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        private void frmDuyurulistesi_Load(object sender, EventArgs e)
        {
            ListBox lst=new ListBox();
            Point lstkonum=new Point(10,10);
            lst.Name = "Listbox1";
            lst.Height = 200;
            lst.Width = 500;
            lst.Location = lstkonum;
            this.Controls.Add(lst);

            //Duyuruları listeleme

            SqlCommand komut=new SqlCommand("select * from TBLDuyurular", bgl.baglanti());
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                lst.Items.Add(dr[0] + " - " + dr[1]);
            }

            bgl.baglanti().Close();
        }
    }
}