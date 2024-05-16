using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float s, m, v; //Declarando as variaveis
            s = 0;

            foreach (Control control in this.Controls) // Vai fazer uma varredura em todos os tipos do Form
            {

                if (control is TextBox) // Vai especificar somente os TextBox
                {
                    v = Convert.ToSingle(control.Text); //ToSingle converte para Float
                    s += v;
                }

                m = s / 3;
                this.Controls["lblResult"].Text = m.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                this.Controls["lblResult"].Text = ". . .";

            }
        }
    }
}
