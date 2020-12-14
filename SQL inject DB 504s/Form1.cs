using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace SQL_inject_DB_504s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginTB(object sender, EventArgs e)
        {

        }

        private void PasswdTB(object sender, EventArgs e)
        {

        }

        Form2 form2 = new Form2();
        private void AuthenticationButton_Click(object sender, EventArgs e)
        {
            string login;
            string password;

            login = loginTB.Text;
            password = passwdTB.Text;

            string connectionString = @"Server=localhost;Initial Catalog=LoginForm;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                string sql = "SELECT Login,Password FROM dbo.Users u WHERE u.Login='" + login + "' and u.Password='" + password + "'";
                SqlCommand comand = new SqlCommand(sql, connection);
                object findUser = comand.ExecuteScalar();
                if (findUser == null)
                    MessageBox.Show("Неверный логин или пароль!");
                else
                    if (findUser.ToString().Contains(login))
                    {
                        MessageBox.Show("Добро пожаловать, " + findUser + "!");
                        ActiveForm.Hide();
                        form2.ShowDialog();
                        Application.Restart();
                    }

                command.Connection = connection;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                string login;
                string password;

                login = loginTB.Text;
                password = passwdTB.Text;

                using (UserContext db = new UserContext())
                {
                    // создаем два объекта User
                    User newUser = new User { Login = login, Password = password, Id = Guid.NewGuid() };

                    // добавляем их в бд
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Новый пользователь создан!");

                }
            }
            catch(Exception ex)
            {
                if(ex.InnerException.InnerException.Message.Contains("Violation of UNIQUE KEY constraint 'AK_Login'. Cannot insert duplicate key in object 'dbo.Users'."))
                    MessageBox.Show("Данный Login уже занят, попробуйте другой!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login;
            string password;

            login = loginTB.Text;
            password = passwdTB.Text;


            UserContext context = new UserContext();

            List<User> findUser = context.Users.Where(w => w.Login.Contains(login) && w.Password.Contains(password)).ToList();

            if (findUser.Count() == 0)
                MessageBox.Show("Неверный логин или пароль!");
            foreach (var user in findUser)
            {
                if (user.Login.Contains(login))
                {
                    MessageBox.Show("Добро пожаловать, " + user.Login + "!");
                    ActiveForm.Hide();
                    form2.Text = "User panel: " + user.Login;
                    form2.ShowDialog();
                    Application.Restart();
                }
            }

            
        }
    }
}
