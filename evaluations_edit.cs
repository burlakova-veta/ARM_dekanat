using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decanat
{
    public partial class evaluations_edit : Form
    {
        int id { get; set; }
        public evaluations_edit(int id_con)
        {
            InitializeComponent();

            id = id_con;
            SQLiteConnection con = new SQLiteConnection(@"data source=dekanat.db");
            con.Open();

            string query = "SELECT Идентификатор_студ, Имя||\" \"|| Фамилия as name FROM Студенты ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            SQLiteCommand CreateCommand = new SQLiteCommand(query, con);


            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(CreateCommand);
            adapter.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Номер_Студента";



            string query1 = "SELECT Идентификатор_дисц, Дисциплина FROM Дисциплины ";

            SQLiteCommand CreateCommand1 = new SQLiteCommand(query1, con);


            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(CreateCommand1);
            adapter1.Fill(dt1);

            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Дисциплина";
            comboBox2.ValueMember = "Номер_Дисциплины";

            string query2 = "SELECT * FROM Оценки WHERE Идентификатор = " + id;

            SQLiteCommand CreateCommand2 = new SQLiteCommand(query2, con);

            using (SQLiteDataReader reader = CreateCommand2.ExecuteReader())
            {
                while (reader.Read()) {
                comboBox1.SelectedValue = reader.GetDecimal("Идентификатор_студ");
                comboBox2.SelectedValue = reader.GetDecimal("Идентификатор_дисц");

                textBox1.Text = reader.GetValue("Оценка").ToString();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = dekanat.db");
            con.Open();
            string Name = comboBox1.GetItemText(0);
            string FName = comboBox1.GetItemText(1);
            string sql = "UPDATE Оценки SET Идентификатор_дисц = '" + comboBox2.SelectedValue.ToString() + "', Идентификатор_студ = '" + comboBox1.SelectedValue.ToString() + "', Оценка = '" + textBox1.Text + "' WHERE Идентификатор = " + id;


            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }
    }
    }

