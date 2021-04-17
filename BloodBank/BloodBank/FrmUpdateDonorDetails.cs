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

    public partial class FrmUpdateDonorDetails : Form
    {
        function fn = new function();
        public FrmUpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            String query = "select * from newDonor where did=" + id + "";
            DataSet ds = fn.GetData(query);

            if(ds.Tables[0].Rows.Count!=0)
                {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMotherName.Text = ds.Tables[0].Rows[0][3].ToString();
                dOfBirth.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobileNo.Text = ds.Tables[0].Rows[0][5].ToString();
                cmbGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                cmbxBlood.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtAdress.Text = ds.Tables[0].Rows[0][10].ToString();
                    }
            else
            {
                MessageBox.Show("Invalid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorID.Text=="")
            {
                txtName.Clear();
                txtFatherName.Clear();
                txtMotherName.Clear();
                dOfBirth.ResetText();
                txtMobileNo.Clear();
                cmbGender.ResetText();
                cmbxBlood.ResetText();
                txtAdress.Clear();
                txtCity.Clear();
                txtEmail.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String query = "update newDonor set dname='"+txtName.Text+"',fname='"+txtFatherName.Text+"',mname='"+txtMotherName.Text+"',dob='"+dOfBirth.Text+"',mobile='"+txtMobileNo.Text+"',gender='"+cmbGender.Text+"',email='"+txtEmail.Text+"',bloodGroup='"+cmbxBlood.Text+"',city='"+txtCity.Text+"',daddress='"+txtAdress.Text+"' where did=" + txtDonorID.Text +" ";
            fn.setDate(query);
            FrmUpdateDonorDetails_Load(this, null);
        }

        private void FrmUpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }
    }
}
