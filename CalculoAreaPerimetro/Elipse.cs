using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculoAreaPerimetro
{
    public partial class Elipse : Form
    {
        private static Elipse instancia;
        public Elipse()
        {
            InitializeComponent();
        }

        public static Elipse ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Elipse();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);  // Semieje mayor
                double b = double.Parse(txtB.Text);  // Semieje menor

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Por favor, ambos semiejes deben ser mayores que cero");
                    return;
                }

                ElipseC elipse = new ElipseC(a, b);
                double area = elipse.CalcularArea();
                double perimetro = elipse.CalcularPerimetro();

                txtArea.Text = area.ToString("F2");
                txtPerimetro.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido para los semiejes");
            }
        }
    }
}
