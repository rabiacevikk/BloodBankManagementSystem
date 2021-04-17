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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

       
        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAddNewDonor fr = new FrmAddNewDonor();
            fr.ShowDialog();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateDonorDetails frm = new FrmUpdateDonorDetails();
            frm.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllDonorDetails frm = new FrmAllDonorDetails();
            frm.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchBloodDonorAdress frm = new FrmSearchBloodDonorAdress();
            frm.Show();
        }
        //Clicking on toolstripmenu opens another form
        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchDonorByBlood frm = new FrmSearchDonorByBlood();
            frm.ShowDialog();
        }

        private void ıncreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockIncrease frm = new FrmStockIncrease();
            frm.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockDecrease frm = new FrmStockDecrease();
            frm.Show();

        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockDetails frm = new FrmStockDetails();
            frm.Show();
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeleteDonor frm = new FrmDeleteDonor();
            frm.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
