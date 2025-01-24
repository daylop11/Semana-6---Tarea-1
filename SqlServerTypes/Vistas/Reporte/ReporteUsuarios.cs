using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_6___Tarea_1.SqlServerTypes.Vistas.Reporte
{
    public partial class ReporteUsuarios : Form
    {
        private object reportViewer1;

        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaUsuarioDataSet.ListaUsuariosYRoles' Puede moverla o quitarla según sea necesario.
            this.listaUsuariosYRolesTableAdapter.Fill(this.vistaUsuarioDataSet.ListaUsuariosYRoles);
            object value = this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
        }
    }
}
