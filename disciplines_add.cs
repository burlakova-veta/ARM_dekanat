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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace decanat
{
    public partial class disciplines_add : Form
    {
        public disciplines_add()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=dekanat.db");
            con.Open();

            string sql = "INSERT INTO Дисциплины (Дисциплина) VALUES ('" + textBox1.Text + "' )";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
