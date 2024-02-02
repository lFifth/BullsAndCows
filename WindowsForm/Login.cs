using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForm
{
    public partial class Login : Form
    {
        private SqlConnection sql = null;
        public Login() { InitializeComponent(); }
        private void RegistrationButton_MouseEnter(object sender, EventArgs e) { RegistrationButton.ForeColor = Color.Gray; }
        private void RegistrationButton_MouseLeave(object sender, EventArgs e) { RegistrationButton.ForeColor = Color.Black; }
        private void CloseButton_Click(object sender, EventArgs e) { Application.Exit(); }
        private void Login_Load(object sender, EventArgs e) { sql = new SqlConnection(ConfigurationManager.ConnectionStrings["add"].ConnectionString); sql.Open(); }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || PasswordBox.Text == "")
            { MessageBox.Show("Не все поля заполнены", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            SqlDataReader reader = null;

            try
            {
                SqlCommand command = new SqlCommand("SELECT Login, Password FROM Connect", sql);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (((string)reader["Login"]).Replace(" ", "") == loginBox.Text)
                    {
                        if (((string)reader["Password"]).Replace(" ", "") == Hash.MD5Hash(PasswordBox.Text))
                        {
                            goto A;
                        }
                        else { MessageBox.Show("Неверный пароль", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    }
                }
                MessageBox.Show("Пользователь не найден", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            A:
                loginBox.Text = "";
                PasswordBox.Text = "";
                this.Hide();
                Game game = new Game();
                game.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e) 
        {
            loginBox.Text = "";
            PasswordBox.Text = "";
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Show();
        }
    }
}
