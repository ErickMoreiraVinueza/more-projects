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
    public partial class Trapezoide : Form
    {
        public static Trapezoide instancia;
        public Trapezoide()
        {
            InitializeComponent();
        }

        public static Trapezoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Trapezoide();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseMayor = double.Parse(txtBaseMayor.Text);
                double baseMenor = double.Parse(txtBaseMenor.Text);
                double ladoIzquierdo = double.Parse(txtLadoIzq.Text);
                double ladoDerecho = double.Parse(txtLadoDer.Text);
                double altura = double.Parse(txtAltura.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || ladoIzquierdo <= 0 || ladoDerecho <= 0 || altura <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                TrapezoideC trapezoide = new TrapezoideC(baseMayor, baseMenor, ladoIzquierdo, ladoDerecho, altura);
                double area = trapezoide.CalcularArea();
                double perimetro = trapezoide.CalcularPerimetro();

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos");
            }
        }
    }
}
