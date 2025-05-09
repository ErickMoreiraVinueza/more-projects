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
    public partial class TrapecioIso : Form
    {
        public static TrapecioIso instancia;
        public TrapecioIso()
        {
            InitializeComponent();
        }
        public static TrapecioIso ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new TrapecioIso();
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
                double ladoOblicuo = double.Parse(txtLadoObli.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || ladoOblicuo <= 0)
                {
                    MessageBox.Show("Por favor, todos los valores deben ser mayores que cero");
                    return;
                }

                TrapecioIsoC trapecio = new TrapecioIsoC(baseMayor, baseMenor, altura, ladoOblicuo);
                double area = trapecio.CalcularArea();
                double perimetro = trapecio.CalcularPerimetro();

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
