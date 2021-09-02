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
    public partial class Resultados : Form
    {
        string votos;
        string nombre = "votos.txt";
        ///Modificar la ruta
        string ruta = "C:\\Users\\EMjr\\Documents\\Universidad\\Ciclo 02 -2021\\POO\\Examenes\\Examenes\\E2-EP1\\votos.txt";

        public Resultados()
        {
            InitializeComponent();
            if (File.Exists(ruta))
            {
                ///Lectura de datos
                string votos= File.ReadAllText(ruta); ;
                double resultado1 , resultado2, resultado3, resultado4;
                ///Conteo de botos
                string[] arreglo = votos.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                ///Contrucutor de contadores
                contadores c = new contadores();
                //Verficar datos ingresados
                for (int i = 0; i < arreglo.Length; i++)
                {
                    ///Suma de votos
                    c.V++;
                    if (arreglo[i] == "1")
                    {
                        c.V1++;
                    }
                    if (arreglo[i] == "2")
                    {
                        c.V2++;
                    }
                    if (arreglo[i] == "3")
                    {
                        c.V3++;
                    }
                    if (arreglo[i] == "4")
                    {
                        c.V4++;
                    }
                }
                ///Calculo de totales
                resultado1 = (c.V1 * 100)/c.V;
                resultado2 = (c.V2 * 100) / c.V;
                resultado3 = (c.V3 * 100) / c.V;
                resultado4 = (c.V4 * 100) / c.V;
                ////Mostrar resultados
                lbtotal.Text = "Votos totales= " + c.V.ToString();
                lb1.Text = resultado1.ToString() + "%";
                lb2.Text = resultado2.ToString() + "%";
                lb3.Text = resultado3.ToString() + "%";
                lb4.Text = resultado4.ToString() + "%";
            }
            else
            {
                MessageBox.Show("No se han ingresado votaciones");
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Visible = true;
            this.Close();
        }
        ///Contadores
        public class contadores
        {
            int v1;
            int v2;
            int v3;
            int v4;
            int v;
            public int V1 { get => v1; set => v1 = value; }
            public int V2 { get => v2; set => v2 = value; }
            public int V3 { get => v3; set => v3 = value; }
            public int V4 { get => v4; set => v4 = value; }
            public int V { get => v; set => v = value; }
        }


    }
}
