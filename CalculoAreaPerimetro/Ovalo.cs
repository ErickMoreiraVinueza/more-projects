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
    public partial class Ovalo : Form
    {
        private static Ovalo instancia;
        public Ovalo()
        {
            InitializeComponent();
        }

        public static Ovalo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Ovalo();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseMayor = double.Parse(txtBase.Text);
                double altura = double.Parse(txtAltura.Text);

                if (baseMayor <= 0 || altura <= 0)
                {
                    MessageBox.Show("Por favor, los valores deben ser mayores que cero");
                    return;
                }

                OvaloC ovalo = new OvaloC(baseMayor, altura);
                double area = ovalo.CalcularArea();
                double perimetro = ovalo.CalcularPerimetro();

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
