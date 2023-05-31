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
    public partial class edit_student : Form
    {
        int id { get; set; }
        public edit_student(int id_con)
        {
            InitializeComponent();

            id = id_con;
            SQLiteConnection con = new SQLiteConnection("data source = dekanat.db");
            con.Open();

            string sql = "SELECT * FROM Студенты WHERE Идентификатор_студ =" + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox1.Text = reader.GetString("Имя");
                    textBox2.Text = reader.GetString("Фамилия");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = dekanat.db");
            con.Open();

            string sql = "UPDATE Студенты " +
                "SET Имя = '" + textBox1.Text + "', Фамилия='" + textBox2.Text + "' WHERE Идентификатор_студ=" + id;


            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }
    }
}
