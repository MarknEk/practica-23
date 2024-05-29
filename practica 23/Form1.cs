using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DataSet MyDataSet = new DataSet();
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
                //Там где находится файл базы данных
                string sBank = @"C:\Bases\Animals.mdb";
                string sSql = "Select * from thisanimals";
                using (OleDbConnection oleConn = new OleDbConnection(connectionString +
                sBank))
                {
                    try
                    {
                        oleConn.Open();
                        OleDbCommand olecmd = new OleDbCommand(sSql, oleConn);
                        olecmd.CommandType = CommandType.Text;
                        OleDbDataAdapter da = new OleDbDataAdapter(olecmd);
                        da.Fill(MyDataSet);
                    }
                    catch (Exception/* ex*/)
                    {
                        return;
                    }
                }
                
            }
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}