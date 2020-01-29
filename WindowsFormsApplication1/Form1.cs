using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CrystalReport3 cr = new CrystalReport3();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            string sql = "select * from QR WHERE ID =" + 1;
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds, "Table1");
            cr.SetDataSource(ds.Tables["Table1"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport3 cr = new CrystalReport3();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            string sql = "select * from QR WHERE ID =" + 2;
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds, "Table1");
            cr.SetDataSource(ds.Tables["Table1"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrystalReport3 cr = new CrystalReport3();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            string sql = "select * from QR WHERE ID =" + 3;
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds, "Table1");
            cr.SetDataSource(ds.Tables["Table1"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }
    }
}
