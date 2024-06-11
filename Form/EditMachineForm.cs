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
    public partial class EditMachineForm : Form
    {
        MySqlConnection conn;
        public EditMachineForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MachineRed.login = textBox1.Text;
                MachineRed.password = textBox2.Text;
                MachineRed.id = textBox3.Text;
                conn.Open();
                string sql = $"INSERT INTO T_Machine (login_Machine, password_Machine, vote_id_Machine) VALUES ('{MachineRed.login}','{MachineRed.password}','{MachineRed.id}')";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"Вы создали машину с логином:{MachineRed.login}");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show($"Вы записали неправильные значения в полях");
                conn.Close();
            }
        }

        private void EditMachineForm_Load(object sender, EventArgs e)
        {
            conn = DBconnect.GetDBConnection();
        }
    }
}
