using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            int id = 0;
            if ((int.TryParse((textBox1.Text), out id))) 
            {
                cus.Id = id;
            }
            cus.FirstName = textBox2.Text;
            cus.LastName = textBox3.Text;
            cus.City = textBox4.Text;
            cus.Country = textBox5.Text;
            cus.Phone = textBox6.Text;
            ShopingBusinessRepo repo = new ShopingBusinessRepo();
            var rs = repo.Create(cus);
            MessageBox.Show(rs + " Id Created...!!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

