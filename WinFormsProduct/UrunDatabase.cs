using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsProduct
{
    internal class UrunDatabase
    {
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public bool Durum { get; set; }
        public decimal Fiyat { get; set; }
        public int ID { get; set; }
        public string Category { get; set; }
        public int CategoryID { get; set; }
        public int Stock { get; set; }
    }

    internal class DbManagement
    {
        const string conString = "server=(LocalDb)\\MSSQLLocalDB;database=ProductDataBase;trusted_connection=true;";
        SqlConnection conn = new SqlConnection(conString);
        public void DbConnect()
        {
            conn.Open();
        }

        public void DbClose()
        {
            conn.Close();
        }
        public List<UrunDatabase> DbGetProduct()
        {
            DbConnect();
            List<UrunDatabase> urunList = new List<UrunDatabase>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UrunDatabase urun = new UrunDatabase()
                {
                    UrunAdi = Convert.ToString(dr["UrunAdi"]),
                    ID = Convert.ToInt32(dr["Id"]),
                    Category = Convert.ToString(dr["Category"]),
                    CategoryID = Convert.ToInt32(dr["CategoryID"]),
                    Stock = Convert.ToInt32(dr["Stock"]),
                    Fiyat = Convert.ToDecimal(dr["Fiyat"]),
                    Marka = Convert.ToString(dr["Marka"]),
                    Country = Convert.ToString(dr["Country"]),
                    Description = Convert.ToString(dr["Description"]),
                    Durum = Convert.ToBoolean(dr["Durum"])

                };
                urunList.Add(urun);
            }
            dr.Close();
            cmd.Dispose();
            DbClose();
            return urunList;
        }

        public void DbUpdateProduct()
        {

        }

        public void DbAddProduct(List<UrunDatabase> urunler)
        {
            DbConnect();
            foreach (var urun in urunler)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, Marka, Country, Description, Durum, Fiyat, Category, CategoryID, Stock) VALUES (@UrunAdi, @Marka, @Country, @Description, @Durum, @Fiyat, @Category, @CategoryID, @Stock)", conn);
                cmd.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
                cmd.Parameters.AddWithValue("@Marka", urun.Marka);
                cmd.Parameters.AddWithValue("@Country", urun.Country);
                cmd.Parameters.AddWithValue("@Description", urun.Description);
                cmd.Parameters.AddWithValue("@Durum", urun.Durum);
                cmd.Parameters.AddWithValue("@Fiyat", urun.Fiyat);
                cmd.Parameters.AddWithValue("@Category", urun.Category);
                cmd.Parameters.AddWithValue("@CategoryID", urun.CategoryID);
                cmd.Parameters.AddWithValue("@Stock", urun.Stock);
                cmd.ExecuteNonQuery();
            }
            DbClose();
        }
    }
}
