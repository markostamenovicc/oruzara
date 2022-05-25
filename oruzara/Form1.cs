using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oruzara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_podaci_Click(object sender, EventArgs e)
        {
            podaci podaci1 = new podaci();
            podaci1.Show();
          
        }

        private void Skladiste_Click(object sender, EventArgs e)
        {
            SKladiste skladiste1 = new SKladiste();
            skladiste1.Show();
        }
    }
}
