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
    public partial class EditVoteForm : Form
    {
        MySqlConnection conn;

        public EditVoteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vote.value += textBox2.Text + ";";
            label4.Text = Vote.value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Vote.quantity = textBox1.Text;
                Vote.name = textBox3.Text;
                string von = "";
                for (int i = 0; i < Convert.ToInt32(Vote.quantity); i++)
                {
                     von += "0;";
                }
                string sql = $"INSERT INTO T_Vote (name_Vote, quantity_Vote, value_Vote, nov_Vote) VALUES ('{Vote.name}','{Vote.quantity}','{Vote.value}','{von}')";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"Вы создали голосование с именем:{Vote.name}");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show($"Вы записали неправльные значения в полях");
                conn.Close();
            }
        }

        private void EditVoteForm_Load(object sender, EventArgs e)
        {
            conn = DBconnect.GetDBConnection();
        }
    }
}
