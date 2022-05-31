
namespace ProyectoLoboSostenido
{
    partial class FrmRPTPermisosRol
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvPermisos = new System.Windows.Forms.ListView();
            this.ID_PermisosReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(26, 43);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(255, 21);
            this.cbRoles.TabIndex = 0;
            this.cbRoles.SelectionChangeCommitted += new System.EventHandler(this.cbRoles_SelectionChangeCommitted);
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(26, 115);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(255, 21);
            this.cbCampus.TabIndex = 1;
            this.cbCampus.SelectionChangeCommitted += new System.EventHandler(this.cbCampus_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCampus);
            this.panel1.Controls.Add(this.cbRoles);
            this.panel1.Location = new System.Drawing.Point(29, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 251);
            this.panel1.TabIndex = 2;
            // 
            // lvPermisos
            // 
            this.lvPermisos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvPermisos.CheckBoxes = true;
            this.lvPermisos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_PermisosReporte,
            this.Nombre});
            this.lvPermisos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvPermisos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPermisos.Location = new System.Drawing.Point(466, 44);
            this.lvPermisos.Name = "lvPermisos";
            this.lvPermisos.Size = new System.Drawing.Size(267, 369);
            this.lvPermisos.TabIndex = 3;
            this.lvPermisos.UseCompatibleStateImageBehavior = false;
            this.lvPermisos.View = System.Windows.Forms.View.Details;
            // 
            // ID_PermisosReporte
            // 
            this.ID_PermisosReporte.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 201;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(713, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FmrRPTPermisosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lvPermisos);
            this.Controls.Add(this.panel1);
            this.Name = "FmrRPTPermisosRol";
            this.Text = "FmrRPTPermisosRol";
            this.Load += new System.EventHandler(this.FmrRPTPermisosRol_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader ID_PermisosReporte;
        private System.Windows.Forms.ColumnHeader Nombre;
    }
}