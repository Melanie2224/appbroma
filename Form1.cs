using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int Random = 200;
        private int x;
        private int y;


        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            {

                btnCancelar.Location = new Point(x, Random);

                x += Random;
                x += Random;


                btnCancelar.Location = new Point(y, Random);



                y += Random;
                y += Random;


            }

        }
    }
}
