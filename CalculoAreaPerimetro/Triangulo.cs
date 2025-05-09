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
    public partial class Triangulo : Form
    {
        public static Triangulo instancia;
        public Triangulo()
        {
            InitializeComponent();
        }
        public static Triangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Triangulo();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(txtLado.Text);
                TrianguloC triangulo = new TrianguloC(lado);
                double area = triangulo.CalcularArea();
                double perimetro = triangulo.CalcularPerimetro();

                txtArea.Text = area.ToString("F2"); //Para mostrar dos decimales
                txtPerimetro.Text = perimetro.ToString("F2"); 
            }
            catch (FormatException) //Valida que no ingrese letras
            {
                MessageBox.Show("Por favor, ingrese un valor númerico válido para el lado");
            }
        }
    }
}
