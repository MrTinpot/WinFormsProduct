using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsProduct
{
    internal class KategoriDataBase
    {
        public string KategoriAdi { get; set; }
        public int KategoriID { get; set; }
    }

    internal class DbKategori
    {
        const string conString = "server=(LocalDb)\\MSSQLLocalDB;database=ProductDataBase;trusted_connection=true;";
        SqlConnection conn = new SqlConnection(conString);
        public void DbOpen()
        {
            conn.Open();
        }

        public void DbClose()
        {
            conn.Close();
        }

        public List<KategoriDataBase> GetKategoriList()
        {
            DbOpen();
            List<KategoriDataBase> kategoriList = new List<KategoriDataBase>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kategori", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KategoriDataBase kategori = new KategoriDataBase()
                {
                    KategoriAdi = Convert.ToString(dr["KategoriAd"]),
                    KategoriID = Convert.ToInt32(dr["ktgID"])
                };
                kategoriList.Add(kategori);
            }
            dr.Close();
            cmd.Dispose();
            DbClose();
            return kategoriList;
        }
        public List<KategoriDataBase> GetKategoriName()
        {
            DbOpen();
            List<KategoriDataBase> kategoriList = new List<KategoriDataBase>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kategori", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KategoriDataBase kategori = new KategoriDataBase()
                {
                    KategoriAdi = Convert.ToString(dr["KategoriAd"]),
                };
                kategoriList.Add(kategori);
            }
            dr.Close();
            cmd.Dispose();
            DbClose();
            return kategoriList;
        }
    }
}
