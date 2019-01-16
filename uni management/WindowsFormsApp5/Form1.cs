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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = "wrong id or password";
            int count=0;
            SqlConnection con = new SqlConnection("data source=.; database=student;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from adminn where   id='" + textBox1.Text + "'and password='" + textBox2.Text + "'",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                count++;
            }
            if(count>=1)
            {
                 this.Hide();
                 Form2 f = new Form2();
                 f.ShowDialog();
            }
            label3.Text = r;

        }
    }
}
