using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if(this.chbMarca1.Checked == true)
            {
                lblResultado.Text = "Selecciono cheque 1";
            }
            if (this.chbMarca2.Checked == true)
            {
                lblResultado.Text = "Selecciono cheque 2";
            }
            if (this.chbMarca3.Checked == true)
            {
                lblResultado.Text = "Selecciono cheque 3";
            }
        }

        private void chbMarca1_CheckedChanged(object sender, EventArgs e)
        {
            chbMarca2.Checked = false;
            chbMarca3.Checked = false;
            rbSuma.Checked = true;
            rbMultiplicacion.Checked = false;
            rbResta.Checked = true;
            rbDivision.Checked = false;
        }

        private void chbMarca2_CheckedChanged(object sender, EventArgs e)
        {
            chbMarca1.Checked = false;
            chbMarca3.Checked = false;
            rbSuma.Checked = false;
            rbMultiplicacion.Checked = true;
            rbResta.Checked = false;
            rbDivision.Checked = true;
        }

        private void chbMarca3_CheckedChanged(object sender, EventArgs e)
        {
            chbMarca1.Checked = false;
            chbMarca2.Checked = false;
            rbSuma.Checked = true;
            rbMultiplicacion.Checked = false;
            rbResta.Checked = false;
            rbDivision.Checked = true;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Ha dado un solo click";
        }

        private void lblResultado_DoubleClick(object sender, EventArgs e)
        {
            lblResultado.Text = "Ha dado doble click";

        }

        private void cbbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbColores.SelectedIndex == 0) 
            {
                lblResultado.ForeColor = Color.Blue;
            }
            if (cbbColores.SelectedIndex == 1)
            {
                lblResultado.ForeColor = Color.Red;
            }
            if (cbbColores.SelectedIndex == 2)
            {
                lblResultado.ForeColor = Color.Green;
            }
            if (cbbColores.SelectedIndex == 3)
            {
                this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            if (cbbColores.SelectedIndex == 4)
            {
                this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            }
            if (cbbColores.SelectedIndex == 5)
            {
                this.BackColor = Color.RosyBrown;
            }
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                cbbColores.Items.Add(i.ToString());
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt2.Text = txt1.Text;
        }
    }
}
