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
    public partial class Rombo : Form
    {
        public static Rombo instancia;
        public Rombo()
        {
            InitializeComponent();
        }
        public static Rombo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Rombo();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double diagonalMayor = double.Parse(txtDiagonalMayor.Text);
                double diagonalMenor = double.Parse(txtDiagonalMenor.Text);
                double lado = double.Parse(txtLado.Text);

                if (diagonalMayor <= 0 || diagonalMenor <= 0 || lado <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                RomboC rombo = new RomboC(diagonalMayor, diagonalMenor, lado);
                double area = rombo.CalcularArea();
                double perimetro = rombo.CalcularPerimetro();

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
