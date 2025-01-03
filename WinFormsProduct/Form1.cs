using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDataBase userdb = new UserDataBase();
            bool loginOk = userdb.LoginTry(txtUsername.Text,txtPassword.Text);
            if ( loginOk==true)
            {
                bool adminCheck = userdb.CheckAdmin(txtUsername.Text, txtPassword.Text);
                MessageBoxButtons msgButton = MessageBoxButtons.OK;
                MessageBox.Show("Giriş Başarılı", "Giriş!", msgButton);
                if (adminCheck == true)
                {
                    label3.Text = $"Hoşgeldiniz! {txtUsername.Text} Yönetici!";
                    groupBox1.Visible = false;
                    gbMenu.Visible = true;
                    button2.Enabled = true;
                }
                else
                {
                    label3.Text = $"Hoşgeldiniz! {txtUsername.Text} Kullanıcı!";
                    groupBox1.Visible = false;
                    gbMenu.Visible = true;
                    button2.Enabled = false;
                }
            }
            else
            {
                MessageBoxButtons msgButton = MessageBoxButtons.OK;
                MessageBox.Show("Giriş Başarısız","Hata!",msgButton);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        urunForm urunForm = new urunForm();
            urunForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManage usr = new UserManage();
            usr.Show();
        }

        private void labelKategoriPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
