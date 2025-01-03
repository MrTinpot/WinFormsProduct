using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProduct
{
    public partial class urunForm : Form
    {
        public urunForm()
        {
            InitializeComponent();
        }

        public void LoadKat()
        {
            SqlConnection conn = new SqlConnection("server=(LocalDb)\\MSSQLLocalDB;database=ProductDataBase;trusted_connection=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KategoriAd FROM Kategori", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                while (dr.Read())
                {
                    cmbCat.Items.Add(dr[0]);
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
        }
        public void urunForm_Load(object sender, EventArgs e)
        {
            DbManagement urunDb = new DbManagement();
            dgUrun.DataSource = urunDb.DbGetProduct();
            LoadKat();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUrunAd.Text))) {
                MessageBox.Show($"{txtUrunAd.Text} Başarıyla Eklendi!", "Ürün Eklendi!", MessageBoxButtons.OK);
                var durumAktif = checkDurum.Checked;
                UrunDatabase urunler = new UrunDatabase()
                {
                    UrunAdi = txtUrunAd.Text,
                    Marka = txtMarka.Text,
                    Country = txtCountry.Text,
                    Description = rtxtDesc.Text,
                    Durum = durumAktif,
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    Category = cmbCat.Text,
                    Stock = Convert.ToInt32(txtStock.Text)
                };
                List<UrunDatabase> urunList = new List<UrunDatabase>();
                urunList.Add(urunler);
                DbManagement db = new DbManagement();
                db.DbAddProduct(urunList);
                dgUrun.DataSource = db.DbGetProduct();
            }
            else { MessageBox.Show("Lütfen geçerli bir ürün adı girinz!", "İsim Hatası!", MessageBoxButtons.OK); }
        }

        private void dgUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAd.Text = dgUrun.CurrentRow.Cells[0].Value.ToString();
            txtMarka.Text = dgUrun.CurrentRow.Cells[1].Value.ToString();
            txtCountry.Text = dgUrun.CurrentRow.Cells[2].Value.ToString();
            rtxtDesc.Text = dgUrun.CurrentRow.Cells[3].Value.ToString();
            checkDurum.Checked = Convert.ToBoolean(dgUrun.CurrentRow.Cells[4].Value);
            txtFiyat.Text = dgUrun.CurrentRow.Cells[5].Value.ToString();
            cmbCat.Text = dgUrun.CurrentRow.Cells[7].Value.ToString();
            txtStock.Text = dgUrun.CurrentRow.Cells[8].Value.ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var CurrentId = Convert.ToInt32(dgUrun.CurrentRow.Cells[6].Value);
            var durumAktif = checkDurum.Checked;
            UrunDatabase urunler = new UrunDatabase()
            {
                UrunAdi = txtUrunAd.Text,
                Marka = txtMarka.Text,
                Country = txtCountry.Text,
                Description = rtxtDesc.Text,
                Durum = durumAktif,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Category = cmbCat.Text,
                Stock = Convert.ToInt32(txtStock.Text)
            };
            List<UrunDatabase> urunList = new List<UrunDatabase>();
            urunList.Add(urunler);
            DbManagement db = new DbManagement();
            db.DbUpdateProduct(CurrentId,urunList);
            dgUrun.DataSource = db.DbGetProduct();
            MessageBox.Show("Başarıyla Güncellendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var CurrentId = Convert.ToInt32(dgUrun.CurrentRow.Cells[6].Value);
            DbManagement db = new DbManagement();
            db.DbDeleteProduct(CurrentId);
            dgUrun.DataSource = db.DbGetProduct();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }
    }
}
