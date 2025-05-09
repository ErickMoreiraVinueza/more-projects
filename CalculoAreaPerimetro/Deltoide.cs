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
    public partial class Deltoide : Form
    {
        public static Deltoide instancia;
        public Deltoide()
        {
            InitializeComponent();
        }

        public static Deltoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Deltoide();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double diagonalMayor = double.Parse(txtDiagonalMayor.Text);
                double diagonalMenor = double.Parse(txtDiagonalMenor.Text);
                double ladoCorto = double.Parse(txtLadoCorto.Text);
                double ladoLargo = double.Parse(txtLadoLargo.Text);

                if (diagonalMayor <= 0 || diagonalMenor <= 0 || ladoCorto <= 0 || ladoLargo <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                DeltoideC deltoide = new DeltoideC(diagonalMayor, diagonalMenor, ladoCorto, ladoLargo);
                double area = deltoide.CalcularArea();
                double perimetro = deltoide.CalcularPerimetro();

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
