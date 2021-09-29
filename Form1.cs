using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Processor processor = new Processor();

            processor.frecuency = 3.60;
            processor.productPrice = 99.99;
            processor.productID = 893932;
            processor.productBrand = "Qualcomm";
            processor.productModel = "Snapdragon";

            MessageBox.Show(processor.getInfo());
            MessageBox.Show(processor.product());
            MessageBox.Show(processor.getInfo());



        }
    }
}
