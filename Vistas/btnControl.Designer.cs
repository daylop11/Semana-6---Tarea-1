namespace Semana_6___Tarea_1.Vistas
{
    partial class btnControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnelEjecucion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Control Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnelEjecucion
            // 
            this.pnelEjecucion.BackColor = System.Drawing.Color.White;
            this.pnelEjecucion.Location = new System.Drawing.Point(-4, 73);
            this.pnelEjecucion.Name = "pnelEjecucion";
            this.pnelEjecucion.Size = new System.Drawing.Size(622, 414);
            this.pnelEjecucion.TabIndex = 1;
            // 
            // btnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 487);
            this.Controls.Add(this.pnelEjecucion);
            this.Controls.Add(this.button1);
            this.Name = "btnControl";
            this.Text = "Control Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnelEjecucion;
    }
}