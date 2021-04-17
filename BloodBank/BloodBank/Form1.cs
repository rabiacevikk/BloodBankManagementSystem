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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Hide")           
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
            else
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                btnLogin.Enabled = false;
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="rabiacevikk" && txtPassword.Text=="pass")   
            {
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Enter Valid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
    }

