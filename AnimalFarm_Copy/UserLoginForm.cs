
using AnimalFarm.Service;
using System;
using System.Windows.Forms;


namespace AnimalFarm
{
    public partial class UserLoginForm : Form
    {
        UserService userService = new UserService();
        public UserLoginForm()
        {
            InitializeComponent();
        }
        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            //deneme amaçlı
            tbxUsername.Text = "deneme";
            tbxPassword.Text = "1234";
        }
        private void materialPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ıconBtnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Geçilemez!");
                return;
            }
            var result = userService.ValidateUser(username, password);

            if (result)
            {
                ContinantalForm cnt = new ContinantalForm();
                cnt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!");
            }
            return;
        }
    }
}

