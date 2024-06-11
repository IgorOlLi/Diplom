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
    public partial class AuthPasportForm : Form
    {
        MySqlConnection conn;
        public AuthPasportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member.passport = maskedTextBox1.Text;
            conn.Open();
            string sql = $"INSERT INTO T_Member (passport_Member, vote_Member) VALUES ('{Member.passport}','{Member.vote}')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"Ваш кандидат: {Member.vote}");
            this.Close();
        }

        private void AuthPasportForm_Load(object sender, EventArgs e)
        {
            conn = DBconnect.GetDBConnection();
        }
    }
}
