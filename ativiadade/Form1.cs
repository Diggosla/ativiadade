using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ativiadade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntenviar_Click(object sender, EventArgs e)
        {
  
            txtreal.Text = (Convert.ToDouble(txtdolar.Text) * 4.94).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           txtdolar.Clear();
            txtreal.Clear();
        }
    }
}
