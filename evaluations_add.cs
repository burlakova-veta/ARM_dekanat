using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace decanat
{
    public partial class evaluations_add : Form
    {

        public evaluations_add()
        {
            InitializeComponent();
            //dt = comboBox1_SelectedIndexChanged_1(comboBox1, e);

            SQLiteConnection con = new SQLiteConnection(@"data source=decan.db");
            con.Open();

            string query = "SELECT Номер_Студента, Имя||\" \"|| Фамилия as name  FROM Студенты ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            SQLiteCommand CreateCommand = new SQLiteCommand(query, con);
            

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(CreateCommand);
            adapter.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Номер_Студента";



            string query1 = "SELECT Номер_Дисциплины, Название FROM Дисциплины ";

            SQLiteCommand CreateCommand1 = new SQLiteCommand(query1, con);


            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(CreateCommand1);
            adapter1.Fill(dt1);

            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Название";
            comboBox2.ValueMember = "Номер_Дисциплины";




            //string selectedState = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedState);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //comboBox1.Items.AddRange(new string[] {});

            //SQLiteCommand command = new SQLiteCommand(query, con);
            //DbDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //comboBox1.Items.Add((string)reader["Имя, Фамилия"]);         //СтолбецТаблицы

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = dekanat.db");
            con.Open();
            string Name = comboBox1.GetItemText(0);
            string FName = comboBox1.GetItemText(1);
            string sql = "INSERT INTO Оценки (Идентфиикатор_дисц, Идентификатор_студ, Оценка) values ('" + comboBox2.SelectedValue.ToString() + "', '" + comboBox1.SelectedValue.ToString() + "', '" + textBox1.Text + "')";


            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }
    }
}
