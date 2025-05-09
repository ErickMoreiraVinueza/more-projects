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
    public partial class Rectangulo : Form
    {
        private static Rectangulo instancia;
        public Rectangulo()
        {
            InitializeComponent();
        }

        public static Rectangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Rectangulo();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRectangulo = double.Parse(txtBase.Text);
                double altura = double.Parse(txtAltura.Text);

                if (baseRectangulo <= 0 || altura <= 0)
                {
                    MessageBox.Show("Por favor, los valores deben ser mayores que cero");
                    return;
                }

                RectanguloC rectangulo = new RectanguloC(baseRectangulo, altura);
                double area = rectangulo.CalcularArea();
                double perimetro = rectangulo.CalcularPerimetro();

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
