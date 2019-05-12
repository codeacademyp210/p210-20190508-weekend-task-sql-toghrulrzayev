using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            User nUser = new User();
            nUser.Username = UserName.Text;
            nUser.Password = Password.Text;
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.ShowDialog();
            this.Hide();
        }
        

    }
}
