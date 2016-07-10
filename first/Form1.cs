using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace first
{
    public partial class Form1 : Form
    {
        SqlConnection dbConnection;
        SqlDataAdapter SDA;
        DataSet DST;

        DataTable nameDataTable = new DataTable("Names");

        public Form1()
        {
            InitializeComponent();
            dbConnection = new SqlConnection("Data Source=192.168.1.214;Initial Catalog=TEST_DB;Persist Security Info=True;User ID=joe;Password=coff33");
            AddCols();
            AddRows();
            dataGridView4.DataSource = nameDataTable;
        }

        private void buttonDoSomething_Click(object sender, EventArgs e)
        {
            labelDoSomething.Text = textDoSomething.Text;
        }

        private void AddCols()
        {
            nameDataTable.Columns.Add("Count", typeof(int));
            nameDataTable.Columns.Add("FirstName", typeof(string));
            nameDataTable.Columns.Add("LastName", typeof(string));
        }

        private void AddRows()
        {
            nameDataTable.Rows.Add(10, "Joe", "Blender");
            nameDataTable.Rows.Add(20, "Jack", "Latter");
            nameDataTable.Rows.Add(30, "Bill", "Grafton");
            nameDataTable.Rows.Add(40, "Val", "Napels");
            nameDataTable.Rows.Add(50, "kylor", "Blackston");
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            DST = new DataSet("testNames");
            SDA = new SqlDataAdapter("select * from Table1", dbConnection);
            SDA.Fill(DST, "TABLE1");
            SqlDataAdapter SDA1 = new SqlDataAdapter("select * from Table2", dbConnection);
            SDA1.Fill(DST, "TABLE2");
            SqlDataAdapter SDA2 = new SqlDataAdapter("select * from Table3", dbConnection);
            SDA2.Fill(DST, "TABLE3");
            dataGridView1.DataSource = DST.Tables[0];
            dataGridView2.DataSource = DST.Tables[1];
            dataGridView3.DataSource = DST.Tables[2];

        }

        private void buttonAddToDataTable_Click(object sender, EventArgs e)
        {
            /*
            DataTable DT = new DataTable();
            SqlDataAdapter SDA3 = new SqlDataAdapter("select * from Table1", dbConnection);
            SDA3.Fill(DT);
            //SqlDataAdapter SDA4 = new SqlDataAdapter("select * from Table2", dbConnection);
            //SDA4.Fill(DT);
            //SqlDataAdapter SDA5 = new SqlDataAdapter("select * from Table3", dbConnection);
            //SDA5.Fill(DT);
            dataGridView4.DataSource = DT;
            */
            dataGridView4.DataSource = nameDataTable;
        }

        private void buttonUpdateDS1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(SDA);
            SDA.Update(DST, "TABLE1");
        }
    }
}
