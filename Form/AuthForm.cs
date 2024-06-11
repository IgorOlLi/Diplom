using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AuthForm : Form
    {
        MySqlConnection conn;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Вход
        {
            Machine.login = textBox1.Text;
            Machine.password = textBox2.Text;
            string sql = "SELECT * FROM T_Machine WHERE login_Machine = @un and password_Machine = @up";
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
            command.Parameters["@un"].Value = Machine.login;
            command.Parameters["@up"].Value = Machine.password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Эта машина не зарегестрированна!");
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            conn = DBconnect.GetDBConnection();
        }
    }
}
