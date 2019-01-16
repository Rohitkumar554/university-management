using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into course(courseid,coursename,coursecredit) values(@courseid,@coursename,@coursecredit)", con);
            cmd.Parameters.Add("@courseid", textBox1.Text);
            cmd.Parameters.Add("@coursename", textBox2.Text);
            cmd.Parameters.Add("@coursecredit", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
