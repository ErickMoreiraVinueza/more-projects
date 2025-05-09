using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoAreaPerimetro
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = Triangulo.ObtenerInstancia();
            triangulo.MdiParent = this;
            if (!triangulo.Visible)
            {
                triangulo.Show();
            }
            else
            {
                triangulo.BringToFront();
            }
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circulo circulo = Circulo.ObtenerInstancia();
            circulo.MdiParent = this;
            if(!circulo.Visible)
            {
                circulo.Show();
            }
            else
            {
                circulo.BringToFront();
            }
        }

        private void óvaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elipse elipse = Elipse.ObtenerInstancia();
            elipse.MdiParent = this;
            if (!elipse.Visible)
            {
                elipse.Show();
            }
            else
            {
                elipse.BringToFront();
            }

        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = Cuadrado.ObtenerInstancia();
            cuadrado.MdiParent = this;
            if (!cuadrado.Visible)
            {
                cuadrado.Show();
            }
            else
            {
                cuadrado.BringToFront();
            }
        }

        private void óvaloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ovalo ovalo = Ovalo.ObtenerInstancia();
            ovalo.MdiParent = this;
            if (!ovalo.Visible)
            {
                ovalo.Show();
            }
            else
            {
                ovalo.BringToFront();
            }
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo = Rectangulo.ObtenerInstancia();
            rectangulo.MdiParent = this;
            if (!rectangulo.Visible)
            {
                rectangulo.Show();
            }
            else
            {
                rectangulo.BringToFront();
            }
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trapecio trapecio = Trapecio.ObtenerInstancia();
            trapecio.MdiParent = this;
            if (!trapecio.Visible)
            {
                trapecio.Show();
            }
            else
            {
                trapecio.BringToFront();
            }
        }

        private void trapecioIsóscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrapecioIso trapecioIso = TrapecioIso.ObtenerInstancia();
            trapecioIso.MdiParent = this;
            if (!trapecioIso.Visible)
            {
                trapecioIso.Show();
            }
            else
            {
                trapecioIso.BringToFront();
            }
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deltoide deltoide = Deltoide.ObtenerInstancia();
            deltoide.MdiParent = this;
            if (!deltoide.Visible)
            {
                deltoide.Show();
            }
            else
            {
                deltoide.BringToFront();
            }
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romboide romboide = Romboide.ObtenerInstancia();
            romboide.MdiParent = this;
            if (!romboide.Visible)
            {
                romboide.Show();
            }
            else
            {
                romboide.BringToFront();
            }
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trapezoide trapezoide = Trapezoide.ObtenerInstancia();
            trapezoide.MdiParent = this;
            if (!trapezoide.Visible)
            {
                trapezoide.Show();
            }
            else
            {
                trapezoide.BringToFront();
            }
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombo rombo = Rombo.ObtenerInstancia();
            rombo.MdiParent = this;
            if (!rombo.Visible)
            {
                rombo.Show();
            }
            else
            {
                rombo.BringToFront();
            }
        }

        private void pentágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono pentangono = Pentagono.ObtenerInstancia();
            pentangono.MdiParent = this;
            if (!pentangono.Visible)
            {
                pentangono.Show();
            }
            else
            {
                pentangono.BringToFront();
            }
        }

        private void hexágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hexagono hexagono = Hexagono.ObtenerInstancia();
            hexagono.MdiParent = this;
            if (!hexagono.Visible)
            {
                hexagono.Show();
            }
            else
            {
                hexagono.BringToFront();
            }
        }

        private void octágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Octagono octagono = Octagono.ObtenerInstancia();
            octagono.MdiParent = this;
            if (!octagono.Visible)
            {
                octagono.Show();
            }
            else
            {
                octagono.BringToFront();
            }
        }

        private void eneágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eneagono eneagono = Eneagono.ObtenerInstancia();
            eneagono.MdiParent = this;
            if (!eneagono.Visible)
            {
                eneagono.Show();
            }
            else
            {
                eneagono.BringToFront();
            }
        }

        private void decágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decagono decagono = Decagono.ObtenerInstancia();
            decagono.MdiParent = this;
            if (!decagono.Visible)
            {
                decagono.Show();
            }
            else
            {
                decagono.BringToFront();
            }
        }
    }
}
