using Google.Protobuf.WellKnownTypes;
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
using System.Xml.Linq;

namespace Diplom
{
    public partial class ResultForm : Form
    {
        MySqlConnection conn;
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            conn = DBconnect.GetDBConnection();
            getIdMachine();
        }
        void getIdMachine()
        {
            conn.Open();
            string sql = $"SELECT vote_id_Machine FROM T_Machine WHERE login_Machine = '{Machine.login}' ";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Machine.id = reader[0].ToString();
            }
            conn.Close();
            
        }
        void doResult()
        {
            
            conn.Open();
            string sql = $"SELECT quantity_Vote, value_Vote, nov_Vote FROM T_Vote WHERE id_Vote= '{Machine.id}' ";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vote.nov = reader[2].ToString();
                Vote.quantity = reader[0].ToString();
                Vote.value = reader[1].ToString();
            }
            int quantity = Convert.ToInt32(Vote.quantity);
            for (int i = 0; i < quantity; i++)
            {
                //MDW.words = Vote.value.Split(new char[] { ';' });
                MDW.votes = Vote.nov.Split(new char[] { ';' });
                Enigma.dop += MDW.words[i] + " " + MDW.votes[i] + " ";

            }
            label2.Text = Enigma.dop;
            conn.Close();
        }
        void update()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Enigma.dop = null;
            doResult();
        }
    }
}
