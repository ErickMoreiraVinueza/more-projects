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
    public partial class Romboide : Form
    {
        public static Romboide instancia;
        public Romboide()
        {
            InitializeComponent();
        }

        public static Romboide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Romboide();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRomboide = double.Parse(txtBase.Text);
                double altura = double.Parse(txtAltura.Text);
                double ladoLateral = double.Parse(txtLadoLateral.Text);

                if (baseRomboide <= 0 || altura <= 0 || ladoLateral <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                RomboideC romboide = new RomboideC(baseRomboide, altura, ladoLateral);
                double area = romboide.CalcularArea();
                double perimetro = romboide.CalcularPerimetro();

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
