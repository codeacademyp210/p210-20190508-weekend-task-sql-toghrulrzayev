using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        List<User> userList;

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            userList = new List<User>();
            User newUser = new User();

            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Name.Text == " " || Surname.Text == "" || Username.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Zehmet olmasa xanalari bos buraxmayin.");
            }
            else if (!Regex.IsMatch(Email.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else
            {
                newUser.Name = Name.Text;
                newUser.Surname = Surname.Text;
                newUser.Username = Username.Text;
                newUser.Email = Email.Text;
                newUser.Password = Password.Text;

                foreach (var item in GridView.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }
          

            userList.Add(newUser);


           Name.Clear();
           Surname.Clear();
           Username.Clear();
           Email.Clear();
           Password.Clear();

            ProductForm pf = new ProductForm();

        }
    }
}
