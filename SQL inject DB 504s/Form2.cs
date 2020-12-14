using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_inject_DB_504s
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            string connectionString = @"Server=localhost;Initial Catalog=LoginForm;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM dbo.Users u WHERE u.Login='" + searchText + "'";
                DataTable dTab1 = new DataTable();
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                sqlDataAdapter1.SelectCommand = new SqlCommand(sql, connection);
                sqlDataAdapter1.Fill(dTab1);
                this.dataGridView1.DataSource = dTab1;
                connection.Close();
            }
        }
    }
}
