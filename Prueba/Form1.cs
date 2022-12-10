using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    { 
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap bitmap;

            if (comboBox1.SelectedIndex == 0)
            {
                bitmap = new Bitmap(@"../../Resources/70-706339_asuka-neon-genesis-png-transparent-png.png");
            }
            else
            {
                bitmap = new Bitmap(@"../../Resources/R.png");
            }

            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap;

            if (i%2 == 0)
            {
                bitmap = new Bitmap(@"../../Resources/70-706339_asuka-neon-genesis-png-transparent-png.png");
            }
            else
            {
                bitmap = new Bitmap(@"../../Resources/R.png");
            }
            pictureBox1.Image = bitmap;
        }
    }
}
