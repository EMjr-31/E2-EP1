using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_EP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            this.Visible = false;
            ingreso.Show();
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Resultados resul = new Resultados();
            this.Visible = false;
            resul.Show();
        }
    }
}
