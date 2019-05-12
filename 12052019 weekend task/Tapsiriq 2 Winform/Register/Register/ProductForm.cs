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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }


        List<Product> productList;

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void Color_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            productList = new List<Product>();
            Product newProduct = new Product();

            newProduct.Name = Name.Text;
            newProduct.Price = Convert.ToDouble(Price.Text);
            newProduct.Category = Category.Text;
            newProduct.Brand = Brand.Text;
            newProduct.Color = Color.Text;
            newProduct.Barcode =Convert.ToInt32(Barcode.Text);
            newProduct.Stock = Stock.Text;
            newProduct.Ad = Ad.Text;


            GridView.Rows.Add(newProduct.Name, newProduct.Price, newProduct.Category, newProduct.Brand, newProduct.Color, newProduct.Barcode,newProduct.Stock,newProduct.Ad);

            productList.Add(newProduct);


            Name.Clear();
            Price.Clear();
            Color.Clear();
            Barcode.Clear();
            Stock.Clear();
            Ad.Clear();
          
        }
    }
}

