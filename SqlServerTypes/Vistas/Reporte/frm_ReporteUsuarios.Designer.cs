using System;

namespace Semana_6___Tarea_1.SqlServerTypes.Vistas.Reporte
{
    partial class frm_ReporteUsuarios
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
            this.vistaUsuarioDataSet1 = new Semana_6___Tarea_1.VistaUsuarioDataSet();
            this.listaUsuariosYRolesTableAdapter1 = new Semana_6___Tarea_1.VistaUsuarioDataSetTableAdapters.ListaUsuariosYRolesTableAdapter();
            this.tableAdapterManager1 = new Semana_6___Tarea_1.VistaUsuarioDataSetTableAdapters.TableAdapterManager();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaUsuarioDataSet1
            // 
            this.vistaUsuarioDataSet1.DataSetName = "VistaUsuarioDataSet";
            this.vistaUsuarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaUsuariosYRolesTableAdapter1
            // 
            this.listaUsuariosYRolesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Semana_6___Tarea_1.VistaUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(291, 174);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(103, 79);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "REPORTE USUARIOS";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(173, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 52);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(91, 174);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(103, 79);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "BIENVENIDO AL MENÚ GENERAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_ReporteUsuarios
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 435);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label1);
            this.Name = "frm_ReporteUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frm_ReporteUsuarios_Load(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VistaUsuarioDataSet vistaUsuarioDataSet1;
        private VistaUsuarioDataSetTableAdapters.ListaUsuariosYRolesTableAdapter listaUsuariosYRolesTableAdapter1;
        private VistaUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
    }
}