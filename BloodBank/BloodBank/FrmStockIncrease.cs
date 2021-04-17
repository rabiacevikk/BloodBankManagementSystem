using System;
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
    public partial class FrmStockIncrease : Form
    {
        function fn = new function();
        String query;
        public FrmStockIncrease()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStockIncrease_Load(object sender, EventArgs e)
        {
            query = "select blood_group,quantity from stock";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity=quantity+ " + cmbBxUnits.Text + "where blood_group='" + cmbBxBloodGroup.Text + "'";
            fn.setDate(query);
            FrmStockIncrease_Load(this, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
