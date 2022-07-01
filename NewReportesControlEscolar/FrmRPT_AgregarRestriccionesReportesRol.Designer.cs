
namespace ProyectoLoboSostenido
{
    partial class FrmAgregarRestriccionesReportesRol
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
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.cBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tvPermisos
            // 
            this.tvPermisos.CheckBoxes = true;
            this.tvPermisos.Location = new System.Drawing.Point(321, 79);
            this.tvPermisos.Name = "tvPermisos";
            this.tvPermisos.Size = new System.Drawing.Size(428, 292);
            this.tvPermisos.TabIndex = 0;
            // 
            // cBoxUsuarios
            // 
            this.cBoxUsuarios.FormattingEnabled = true;
            this.cBoxUsuarios.Location = new System.Drawing.Point(44, 95);
            this.cBoxUsuarios.Name = "cBoxUsuarios";
            this.cBoxUsuarios.Size = new System.Drawing.Size(237, 21);
            this.cBoxUsuarios.TabIndex = 1;
            this.cBoxUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cBoxUsuarios_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(593, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(44, 54);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(237, 21);
            this.cbCampus.TabIndex = 3;
            this.cbCampus.SelectionChangeCommitted += new System.EventHandler(this.cbCampus_SelectionChangeCommitted);
            // 
            // FrmAgregarRestriccionesReportesRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCampus);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cBoxUsuarios);
            this.Controls.Add(this.tvPermisos);
            this.Name = "FrmAgregarRestriccionesReportesRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarRestriccionesReportesRol";
            this.Load += new System.EventHandler(this.FrmAgregarRestriccionesReportesRol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermisos;
        private System.Windows.Forms.ComboBox cBoxUsuarios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbCampus;
    }
}