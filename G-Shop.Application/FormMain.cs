using G_Shop.Application.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop.Application
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            productsPage1.BringToFront();
        }

        private void buttonChek_Click(object sender, EventArgs e)
        {
            chekPage1.BringToFront();
        }
    }
}
