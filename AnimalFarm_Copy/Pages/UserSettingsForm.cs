using AnimalFarm.Data;
using AnimalFarm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFarm.Pages
{
    public partial class UserSettingsForm : Form
    {
        UserService userService = new UserService();
        public UserSettingsForm()
        {
            InitializeComponent();
        }
        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            userListModelBindingSource.DataSource = userService.GetUserList().OrderBy(u => u.UserName);
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUserName.Text))
            {
                MessageBox.Show("User name boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tbxUserPassword.Text))
            {
                MessageBox.Show("Şifre boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tbxUserKind.Text))
            {
                MessageBox.Show("Kullanıcı Tipi boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbxUserPassword.Text.Length < 6 || tbxUserPassword.Text.Length > 10)
            {
                MessageBox.Show("Şifre en az 6 en fazla 10 karakter olabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string userName = tbxUserName.Text;
            string password = tbxUserPassword.Text;
            int kind = Convert.ToInt32(tbxUserKind.Text);
            var newUser = new USER()
            {
                USER_KIND = kind,
                USER_NAME = userName,
                USER_PASSWORD = password,
            };
            var saveResult = userService.InsertUser(newUser);
            if (saveResult.Item1)
            {
                MessageBox.Show(saveResult.Item2, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userListModelBindingSource.DataSource = userService.GetUserList().OrderBy(u => u.UserName);
            }
            else
            {
                MessageBox.Show(saveResult.Item2);
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kullanıcı Kaydı Silinecektir.Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                int id = Convert.ToInt32(dataGridAnimalUser.CurrentRow.Cells[0].Value.ToString());
                var saveDelete = userService.DeleteUser(id);
                if (saveDelete.Item1)
                {
                    MessageBox.Show(saveDelete.Item2, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userListModelBindingSource.DataSource = userService.GetUserList().OrderBy(u => u.UserName);
                    return;
                }
                else
                {
                    MessageBox.Show(saveDelete.Item2);

                }
            }
        }
    }
}
