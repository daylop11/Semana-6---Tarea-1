using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_6___Tarea_1.Vistas
{
    public partial class btnControl : Form
    {
        public btnControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrtlUsPrueba crtlUsPrueba = new CrtlUsPrueba();
            if (pnelEjecucion.Contains(crtlUsPrueba) == false)
            {
                pnelEjecucion.Controls.Add(crtlUsPrueba);
                crtlUsPrueba.Dock = DockStyle.Fill;
                crtlUsPrueba.BringToFront();
            }
            else
            {
                crtlUsPrueba.BringToFront();
            }
        }
    }
}
