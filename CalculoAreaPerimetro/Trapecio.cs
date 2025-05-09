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
    public partial class Trapecio : Form
    {
        public static Trapecio instancia;
        public Trapecio()
        {
            InitializeComponent();
        }

        public static Trapecio ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Trapecio();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseMayor = double.Parse(txtBaseMayor.Text);
                double baseMenor = double.Parse(txtBaseMenor.Text);
                double altura = double.Parse(txtAltura.Text);
                double ladoIzq = double.Parse(txtLadoIzq.Text);
                double ladoDer = double.Parse(txtLadoDer.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || ladoIzq <= 0 || ladoDer <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero.");
                    return;
                }

                TrapecioC trapecio = new TrapecioC(baseMayor, baseMenor, altura, ladoIzq, ladoDer);
                double area = trapecio.CalcularArea();
                double perimetro = trapecio.CalcularPerimetro();

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
