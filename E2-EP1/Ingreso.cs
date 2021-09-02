using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace E2_EP1
{
    public partial class Ingreso : Form
    {
         string votos;
         string nombre = "votos.txt";
         string  ruta = "C:\\Users\\EMjr\\Documents\\Universidad\\Ciclo 02 -2021\\POO\\Examenes\\Examenes\\E2-EP1\\votos.txt";
        

        public Ingreso()
        {
            InitializeComponent();
            if (File.Exists(ruta))
            {
                btnGuardar.Visible = false;
                btnDescartar.Visible = false;
               
            }
            else
            {
                btnVer.Visible = false;
            }
           
           
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Visible = true;
            this.Close();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ///Ingreso de votos
            votos = rtxtVotos.Text;
            string[] arreglo = votos.Split(",".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            bool estado=true;

            for (int i=0; i < arreglo.Length; i++)
            {
                if (arreglo[i] != "1" && arreglo[i] != "2" && arreglo[i] != "3" && arreglo[i] != "5")
                {
                    estado =true;
                }
                else {
                    MessageBox.Show("No se permiten votos diferentes de 1,2,3 o 4");
                    estado = false;
                    break;
                }            
            }
            if (estado == true) {
            }
            File.WriteAllText(ruta, votos);
            MessageBox.Show("Guardado Exitosamente");

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            rtxtVotos.Text= File.ReadAllText(ruta);
            btnVer.Visible = false;
            btnGuardar.Visible = true;
            btnDescartar.Visible = true;
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            rtxtVotos.Text = File.ReadAllText(ruta);
        }
    }
}
