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
using static System.Net.Mime.MediaTypeNames;

namespace Diplom
{
    public partial class BaseForm : Form
    {
        private RadioButton selectedrb;
        MySqlConnection conn;
        string roflstr = "Путин;Медведев;Слуцкий;";
        
        public BaseForm()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e) // Подмена Форм
        {
            conn = DBconnect.GetDBConnection();
            try
            {
                conn.Open();
                conn.Close();
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
                changeform();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Не удалось подключится к БД, измените адрес БД");
            }
            
        }
        void changeform() // Берет данные из бд и меняет форму
        {
            int quantity = 0;
            string value = "";
            string name = "";
            conn.Open();
            string sql = $"SELECT name_Vote, quantity_Vote, value_Vote FROM T_Machine m1, T_Vote v1 WHERE m1.vote_id_Machine=v1.id_Vote";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader[0].ToString();
                quantity = Convert.ToInt32(reader[1].ToString());
                value = reader[2].ToString();
            }
            reader.Close();
            conn.Close();

            for (int i = 0; i < quantity; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new System.Drawing.Point(6, 19 + 25*i);
                MDW.words = value.Split(new char[] { ';' });
                radioButton.Text = MDW.words[i];
                radioButton.Name = "radioButton" + i;
                radioButton.Size = new System.Drawing.Size(73, 17);
                radioButton.TabIndex = 2;
                radioButton.TabStop = true;
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
                this.groupBox1.Controls.Add(radioButton);
            }
            label2.Text = name;
        }

        private void button1_Click(object sender, EventArgs e) // Проголосовать
        {
            if (selectedrb != null)
            {
                Member.vote = selectedrb.Text;
                AuthPasportForm authPassportForm = new AuthPasportForm();
                authPassportForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Вы Не Выбрали");
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) 
        {
            {
                RadioButton rb = sender as RadioButton;

                if (rb == null)
                {
                    MessageBox.Show("Sender is not a RadioButton");
                    return;
                }

                if (rb.Checked)
                {
                    selectedrb = rb;
                }
            }
        }

        private void изменитьГолосованиеToolStripMenuItem_Click(object sender, EventArgs e) // Меняет панель на форму
        {
            panel1.Controls.Clear();
            EditVoteForm editVoteForm = new EditVoteForm()
            {
                TopLevel = false,
                TopMost = true
            };
            editVoteForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(editVoteForm);
            editVoteForm.Show();
        }

        private void добавитьМашинуToolStripMenuItem_Click(object sender, EventArgs e) // Меняет панель на форму
        {
            panel1.Controls.Clear();
            EditMachineForm editMachineForm = new EditMachineForm()
            {
                TopLevel = false,
                TopMost = true
            };
            editMachineForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(editMachineForm);
            editMachineForm.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            hideButton.Hide();
            panel1.Hide();
        }

        private void посмотретьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ResultForm resultForm = new ResultForm()
            {
                TopLevel = false,
                TopMost = true
            };
            resultForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(resultForm);
            resultForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
