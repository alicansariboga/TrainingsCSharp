using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var labelProductText = "Urunler";
            var labelCartText = "Sepetim";
            var buttonAddToCart = "Sepete Ekle";
            var buttonConfirmCart = "Sepeti Onayla";
            var buttonRemoveItems = "Sepetten Kaldir";
            var buttonClearCart = "Sepeti Temizle";


            lblProducts.Text = labelProductText;
            lblCart.Text = labelCartText;
            btnAddToCart.Text = buttonAddToCart;
            btnConfirmCart.Text = buttonConfirmCart;
            btnRemoveFromCart.Text = buttonRemoveItems;
            btnClearCart.Text = buttonClearCart;

            string[] products = new string[] { "Matematik Kitabi", "Turkce Kitabi", "Tarih Kitabi", "Cografya Kitabi", "Fizik Kitabi", "Kimya Kitabi", "Biyoloji Kitabi" };

            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }

            if(lbxCart.Items.Count == 0)
            {
                btnConfirmCart.Enabled = false;
                btnRemoveFromCart.Enabled = false;
                btnClearCart.Enabled = false;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnConfirmCart.Enabled = true;
                btnRemoveFromCart.Enabled = true;
                btnClearCart.Enabled = true;
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lutfen bir urun seciniz.");
            }
        }

        private void btnConfirmCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepetiniz Onaylandi.");
            lbxCart.Items.Clear();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if()
            lbxProducts.Items.Add(lbxCart.SelectedItem);
            lbxCart.Items.Remove(lbxCart.SelectedItem);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Clear();
        }
    }
}
