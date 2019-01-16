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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into courseregister(sid,cid) values(@sid,@cid)", con);
            cmd.Parameters.Add("@sid", textBox1.Text);
            cmd.Parameters.Add("@cid", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
