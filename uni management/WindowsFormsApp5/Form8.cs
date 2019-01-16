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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student;integrated security=SSPI");
            con.Open();
            string query =  "select coursename from course where courseid in (select cid from courseregister where sid =2)" ;
            SqlDataAdapter da = new SqlDataAdapter("select coursename from course where courseid in (select cid from courseregister where sid =2);", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "course");
            dataGridView1.DataSource = ds.Tables["course"];
        }
    }
}
