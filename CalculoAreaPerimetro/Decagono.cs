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
    public partial class Decagono : Form
    {
        public static Decagono instancia;
        public Decagono()
        {
            InitializeComponent();
        }

        public static Decagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Decagono();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(txtLado.Text);
                double apotema = double.Parse(txtApotema.Text);

                if (lado <= 0 || apotema <= 0)
                {
                    MessageBox.Show("Por favor, los valores deben ser mayores que cero.");
                    return;
                }

                DecagonoC decagono = new DecagonoC(lado, apotema);
                double area = decagono.CalcularArea();
                double perimetro = decagono.CalcularPerimetro();

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
