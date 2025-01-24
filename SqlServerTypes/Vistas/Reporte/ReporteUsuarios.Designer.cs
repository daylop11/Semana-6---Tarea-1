namespace Semana_6___Tarea_1.SqlServerTypes.Vistas.Reporte
{
    partial class ReporteUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listaUsuariosYRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaUsuarioDataSet = new Semana_6___Tarea_1.VistaUsuarioDataSet();
            this.listaUsuariosYRolesTableAdapter = new Semana_6___Tarea_1.VistaUsuarioDataSetTableAdapters.ListaUsuariosYRolesTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosYRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuariosYRolesBindingSource
            // 
            this.listaUsuariosYRolesBindingSource.DataMember = "ListaUsuariosYRoles";
            this.listaUsuariosYRolesBindingSource.DataSource = this.vistaUsuarioDataSet;
            // 
            // vistaUsuarioDataSet
            // 
            this.vistaUsuarioDataSet.DataSetName = "VistaUsuarioDataSet";
            this.vistaUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaUsuariosYRolesTableAdapter
            // 
            this.listaUsuariosYRolesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listaUsuariosYRolesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Semana_6___Tarea_1.SqlServerTypes.Vistas.Reporte.ReporteUsuarios.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(44, 38);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 8);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Semana_6___Tarea_1.SqlServerTypes.Vistas.Reporte.ReporteUsuarios.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(800, 450);
            this.reportViewer3.TabIndex = 1;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReporteUsuarios";
            this.Text = "ReporteUsuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosYRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private VistaUsuarioDataSet vistaUsuarioDataSet;
        private System.Windows.Forms.BindingSource listaUsuariosYRolesBindingSource;
        private VistaUsuarioDataSetTableAdapters.ListaUsuariosYRolesTableAdapter listaUsuariosYRolesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}