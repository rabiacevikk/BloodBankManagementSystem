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
    public partial class FrmAddNewDonor : Form
    {
        function fn = new function();

        public FrmAddNewDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from NewDonor";
            DataSet ds = fn.GetData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            lblNewDonorID.Text = (count+1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFatherName.Text != "" && txtMotherName.Text != "" && dOfBirth.Text != "" && txtMobileNo.Text != "" && cmbGender.Text != "" && txtEmail.Text != "" && cmbxBlood.Text != "" && txtCity.Text != "" && txtAdress.Text != "")
            {
                String dname = txtName.Text;           //record
                String fname = txtFatherName.Text;
                String mname = txtMotherName.Text;
                String dob = dOfBirth.Text;
                String mobile = txtMobileNo.Text;
                String gender = cmbGender.Text;
                String email = txtEmail.Text;
                string bgroup = cmbxBlood.Text;
                String city = txtCity.Text;
                String address = txtAdress.Text;
                String query = "insert into newDonor(dname,fname,mname,dob,mobile,gender,email,bloodGroup,city,daddress) values('" +dname+ "','" +fname+ "','"+mname+"','" +dob+ "','" +mobile+ "','" +gender+ "','" +email+ "','" +bgroup+ "','" +city+"','" +address+ "')";
                MessageBox.Show("Success");
                fn.GetData(query);
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            dOfBirth.ResetText();
            txtMobileNo.Clear();
            cmbGender.ResetText();
            txtEmail.Clear();
            cmbxBlood.ResetText();
            txtCity.Clear();
            txtAdress.Clear();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

            txtName.Clear();               //cleaning items
            txtFatherName.Clear();
            txtMotherName.Clear();
            dOfBirth.ResetText();
            txtMobileNo.Clear();
            cmbGender.ResetText();
            txtEmail.Clear();
            cmbxBlood.ResetText();
            txtCity.Clear();
            txtAdress.Clear();
        }

        private void lblNewDonorID_Click(object sender, EventArgs e)
        {

        }
    }
}

