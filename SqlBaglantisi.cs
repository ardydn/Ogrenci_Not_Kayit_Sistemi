using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace OgrenciNotKayit2
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-QTDSAOT\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
