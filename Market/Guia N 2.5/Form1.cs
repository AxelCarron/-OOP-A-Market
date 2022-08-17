using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_N_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            int Dinero,m50, m20, m10, m5, m2, m1;                  
            int Fanta = 15;
            int CocaCola = 55;
            int Pepsi = 75;
            int Sprite = 35;
            Dinero = Convert.ToInt32(txtDinero.Text);


            if (rbFanta.Checked)
            {
                Dinero = Dinero - Fanta;
              
            }

            if (rbSprite.Checked)
            {
                Dinero = Dinero - Sprite;

            }

            if (rbPepsi.Checked)
            {
                Dinero = Dinero - Pepsi;

            }

            if (rbCocaCola.Checked)
            {
                Dinero = Dinero - CocaCola;
            }


            if (Dinero >= 50 || Dinero >= 20 || Dinero >= 10 || Dinero >= 5 || Dinero >= 2 || Dinero >= 1)
            {
                m50 = Dinero / 50;
                Dinero = Dinero % 50;

                m20 = Dinero / 20;
                Dinero = Dinero % 20;

                m10 = Dinero / 10;
                Dinero = Dinero % 10;

                m5 = Dinero / 5;
                Dinero = Dinero % 5;

                m2 = Dinero / 2;
                Dinero = Dinero % 2;

                m1 = Dinero / 1;
                Dinero = Dinero % 1;

                lblCanjear.Text = "La cantidad de monedas de 50 centavos es: " + m50 + "\n" + "La cantidad de monedas de 20 centavos es: " + m20 + "\n" + "La cantidad de monedas de 10 centavos es: " + m10 + "\n" + "La cantidad de monedas de 5 centavos es: " + m5 + "\n" + "La cantidad de monedas de 2 centavos es: " + m2 + "\n" + "La cantidad de monedas de 1 centavos es: " + m1;

            }                 

        }
       
    }
}
