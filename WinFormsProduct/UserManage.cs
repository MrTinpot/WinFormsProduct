using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProduct
{
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            UserDataBase usdb = new UserDataBase();
            usdb.GetUsers();
            dgvUser.DataSource = usdb.GetUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDataBase usdb = new UserDataBase();
            if ((string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya Şifreyi boş bırakmayınız");
                txtUsername.Text = "";
                txtPassword.Text = "";
                dgvUser.DataSource = usdb.GetUsers();
            }
            else
            {
                usdb.AddUser(txtUsername.Text, txtPassword.Text,checkAdmin.Checked);
                MessageBox.Show($"{txtUsername.Text} Adlı Kayıt başarıyla Eklendi!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                dgvUser.DataSource = usdb.GetUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserDataBase usdb = new UserDataBase();
            if ((string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya Şifreyi boş bırakmayınız");
                txtUsername.Text = "";
                txtPassword.Text = "";
                dgvUser.DataSource = usdb.GetUsers();
            }
            else
            {
                int id = Convert.ToInt32(dgvUser.CurrentRow.Cells[2].Value);
                usdb.UpdateUser(txtUsername.Text, txtPassword.Text, checkAdmin.Checked,id);
                txtUsername.Text = "";
                txtPassword.Text = "";
                checkAdmin.Checked = false;
                dgvUser.DataSource = usdb.GetUsers();
                MessageBox.Show($"{id} Id'li Kayıt başarıyla Güncellendi!");
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            txtUsername.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            checkAdmin.Checked = Convert.ToBoolean(dgvUser.CurrentRow.Cells[2].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUser.CurrentRow.Cells[2].Value);
            UserDataBase usdb = new UserDataBase();
            usdb.DeleteUser(id);
            txtUsername.Text = "";
            txtPassword.Text = "";
            checkAdmin.Checked = false;
            dgvUser.DataSource = usdb.GetUsers();
            MessageBox.Show($"{id} Id'li Kayıt Başarıyla Silindi!");
        }
    }
}
