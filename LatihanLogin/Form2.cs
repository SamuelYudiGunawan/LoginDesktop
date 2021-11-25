using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnama.Text) || String.IsNullOrEmpty(txtkelas.Text) || String.IsNullOrEmpty(txtabsen.Text))
            {
                MessageBox.Show("Text is required!");
            }   
            else
            {
                MessageBox.Show("Nama anda adalah " + txtnama.Text + ", kelas anda " + txtkelas.Text + ", absen anda " + txtabsen.Text + ".");
            }
        }
    }
}
