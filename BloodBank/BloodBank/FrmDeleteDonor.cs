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
    public partial class FrmDeleteDonor : Form
    {
        function fn = new function();
        string query;
        public FrmDeleteDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDonorID.Text!="")
            {
                query = "select * from newDonor where did=" + txtDonorID.Text + "";
                DataSet ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count!=0)
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
                    MessageBox.Show("No Record Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorID.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)   //delete query
        {
            if (MessageBox.Show("Are you sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = "delete from newDonor where did=" + txtDonorID.Text + "";
                fn.setDate(query);
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorID.Text=="")
            {
                txtAdress.Clear();
                txtCity.Clear();
                txtName.Clear();
                txtMotherName.Clear();
                txtFatherName.Clear();
                dOfBirth.ResetText();
                cmbGender.ResetText();
                cmbxBlood.ResetText();
                txtMobileNo.Clear();
                txtEmail.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();   
        }
    }
}
