using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForm
{
    public partial class Registration : Form
    {
        private SqlConnection sql = null;
        public Registration() { InitializeComponent(); }
        private void Registration_Load(object sender, EventArgs e) { sql = new SqlConnection(ConfigurationManager.ConnectionStrings["add"].ConnectionString); sql.Open(); }
        private void CloseButton_Click(object sender, EventArgs e) { this.Close(); }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || PasswordBox.Text == "" || RepeatPasswordBox.Text == "")
            { MessageBox.Show("Не все поля заполнены", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (PasswordBox.Text != RepeatPasswordBox.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataReader reader = null;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT Login, Password FROM Connect", sql);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (((string)reader["Login"]).Replace(" ", "") == loginBox.Text)
                    {
                        MessageBox.Show("Аккаунт с таким именем уже существует", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
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
            command = new SqlCommand($"INSERT INTO [Connect] (Login, Password) VALUES ('{loginBox.Text}', '{Hash.MD5Hash(PasswordBox.Text)}')", sql);
            command.ExecuteNonQuery();
            MessageBox.Show("Ваш аккаунт успешно создан", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
