using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public void urunForm_Load(object sender, EventArgs e)
        {
            DbManagement urunDb = new DbManagement();
            dgUrun.DataSource = urunDb.DbGetProduct();
            DbKategori kategoriDb = new DbKategori();
            cmbKategori.DataSource = kategoriDb.GetKategoriName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    Category = cmbKategori.Text,
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
