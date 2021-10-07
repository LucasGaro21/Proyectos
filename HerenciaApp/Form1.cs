using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPiso.Checked == true)
            {
                txtBoxNroVentanas.Enabled = false;
            }

            if (rdPiso.Checked == true)
            {
                txtBoxNroPiso.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLocal.Checked == true)
            {
                txtBoxNroVentanas.Enabled = true;
            }
            if (rdLocal.Checked == true)
            {
                txtBoxNroPiso.Enabled = false;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = 0;
            precio = precio + Convert.ToDouble(txtBoxPrecioBase.Text);
            double antiguedad = Convert.ToDouble(txtBoxAntiguedad.Text);
            if (antiguedad <= 15)
            {
                precio = precio * 0.99;
            }
            else
            {
                precio = precio * 0.98;
            }

            if(rdPiso.Checked == true)
            {
                int nroPiso = Convert.ToInt32(txtBoxNroPiso.Text);
                double incremento = 0;
                if (nroPiso <= 3)
                {
                    
                    incremento = precio / 97;
                    precio = precio + incremento;
                }
            }

            if(rdLocal.Checked == true)
            {
                int nroVentanas = Convert.ToInt32(txtBoxNroVentanas.Text);
                int superficie = Convert.ToInt32(txtBoxSuperficie.Text);               
                double incremento = 0;
                if (superficie >= 50)
                {
                    incremento = precio / 99;
                    precio = precio + incremento;
                }
                if (nroVentanas >= 1)
                {
                    precio = precio * 0.98;
                }
                else if(nroVentanas >= 4)
                {
                    incremento = precio / 98;
                    precio = precio + incremento;
                }
            }
            MessageBox.Show("Precio Total es de: "+ precio ,"Venta de Inmuebles") ;
        }
    }
}
