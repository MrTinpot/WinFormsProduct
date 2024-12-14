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
            Form kategori = new kategoriForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUrunAd.Text))) {
                MessageBox.Show($"{txtUrunAd.Text} Başarıyla Eklendi!", "Ürün Eklendi!", MessageBoxButtons.OK);
                var durumAktif = checkDurum.Checked;
                dgUrun.Rows.Add(txtUrunAd.Text, txtMarka.Text, txtCountry.Text, rtxtDesc.Text, durumAktif);
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
