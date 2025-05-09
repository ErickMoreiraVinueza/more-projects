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
    public partial class Circulo : Form
    {
        public static Circulo instancia;
        public Circulo()
        {
            InitializeComponent();
        }

        public static Circulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Circulo();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = double.Parse(txtRadio.Text);

                if (radio <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un radio mayor que cero");
                    return;
                }

                CirculoC circulo = new CirculoC(radio);
                double area = circulo.CalcularArea();
                double perimetro = circulo.CalcularPerimetro();

                txtArea.Text = area.ToString("F2");         //Para mostrar 2 decimales
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException) //Valida que no ingrese letras
            {
                MessageBox.Show("Ingrese un valor numérico válido para el radio");
            }
        }
    }
}
