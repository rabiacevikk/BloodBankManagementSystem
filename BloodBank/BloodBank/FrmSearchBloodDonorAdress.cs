﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BloodBank
{
    public partial class FrmSearchBloodDonorAdress : Form
    {
        function fn = new function();
        public FrmSearchBloodDonorAdress()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchBloodDonorAdress_Load(object sender, EventArgs e)
        {
            String query = "select * from newDonor";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtAdress.Text!="")
            {
                String query = "select * from newDonor where city Like '" + txtAdress.Text + "%' or daddress Like'" + txtAdress.Text + "%'";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string query = "select * from newDonor";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
