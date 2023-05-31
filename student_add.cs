using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decanat
{
    public partial class student_add : Form
    {
        public student_add()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=dekanat.db");
            con.Open();

            string sql = "INSERT INTO Студенты (Фамилия, Имя, Отчество, Группа, Телефон) VALUES ('" + textBox2.Text + "', '" + textBox1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox3.Text + "' )";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
