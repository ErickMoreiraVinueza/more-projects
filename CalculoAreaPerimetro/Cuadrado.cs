using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoAreaPerimetro
{
    public partial class Cuadrado : Form
    {
        public static Cuadrado instancia;
        public Cuadrado()
        {
            InitializeComponent();
        }

        public static Cuadrado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Cuadrado();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(txtLado.Text);

                if (lado <= 0)
                {
                    MessageBox.Show("Por favor, el lado debe ser mayor que cero");
                    return;
                }

                CuadradoC cuadrado = new CuadradoC(lado);
                double area = cuadrado.CalcularArea();
                double perimetro = cuadrado.CalcularPerimetro();

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, Ingrese un valor numérico válido para el lado");
            }
        }
    }
}
