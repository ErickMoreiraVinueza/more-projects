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
    public partial class Eneagono : Form
    {
        public static Eneagono instancia;
        public Eneagono()
        {
            InitializeComponent();
        }

        public static Eneagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Eneagono();
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
                    MessageBox.Show("Por favor, los valores deben ser mayores que cero");
                    return;
                }

                EneagonoC eneagono = new EneagonoC(lado, apotema);
                double area = eneagono.CalcularArea();
                double perimetro = eneagono.CalcularPerimetro();

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
