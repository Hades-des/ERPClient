using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practika
{
  
        public partial class LoginForm : Form
        {
        bool isImage1Shown = true;
        private string connectionString = "Server=HADESLOW;Database=ERP;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            button2.BackgroundImage = Properties.Resources.invisible;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.BackColor = Color.FromArgb(40, 40, 40);
        }

        // Обработчик кнопки "Войти"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.");
                return;
            }

            // Выполняем авторизацию
            if (AuthenticateUser(username, password))
            {
                //MessageBox.Show("Авторизация прошла успешно!");
                // Открыть главное окно
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Скрыть форму входа
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }

        // Метод для проверки данных пользователя
        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            // Хешируем введенный пароль
            string hashedPassword = HashPassword(password);

            // SQL-запрос для поиска пользователя с хешированным паролем
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @username AND PasswordHash = @password";
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);  // Передаем хешированный пароль
                //MessageBox.Show(Convert.ToString(username)+ " " + "пароль:" + Convert.ToString(hashedPassword), "Отладка пароля");
                try
                {
                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    if (result > 0)
                    {
                        isAuthenticated = true;  // Пароль верный
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }

            return isAuthenticated;
        }

        // Метод для хеширования пароля с использованием SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Преобразуем пароль в байты и хешируем
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Преобразуем хеш в строку
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
            else { txtPassword.PasswordChar = '\0'; }
            if (isImage1Shown)
            {
                button2.BackgroundImage = Properties.Resources.visible;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(232)))), ((int)(((byte)(158)))));
                isImage1Shown = false;
            }
            else
            {
                button2.BackgroundImage = Properties.Resources.invisible;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121))))); 
                isImage1Shown = true;
            }
            button2.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}


