﻿using System;
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
            bool loginOk = LoginTry();
            if ( loginOk==true)
            {
                MessageBoxButtons msgButton = MessageBoxButtons.OK;
                MessageBox.Show("Giriş Başarılı", "Giriş!", msgButton);
                groupBox1.Visible = false;
                gbMenu.Visible = true;
                label3.Text = $"Hoşgeldiniz! {txtUsername.Text}";
            }
            else
            {
                MessageBoxButtons msgButton = MessageBoxButtons.OK;
                MessageBox.Show("Giriş Başarısız","Hata!",msgButton);
            }
        }
        private bool LoginTry() {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                return true;
            }else { return false; }
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
            kategoriForm k = new kategoriForm();
            k.Show();
        }

        private void labelKategoriPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
