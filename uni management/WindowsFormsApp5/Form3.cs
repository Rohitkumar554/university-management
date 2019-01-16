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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student(id,name,age) values(@id,@name,@age)", con);
            cmd.Parameters.Add("@id",textBox1.Text);
            cmd.Parameters.Add("@name",textBox2.Text);
            cmd.Parameters.Add("@age",textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
