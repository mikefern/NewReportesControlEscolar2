
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPTPermisosRol));
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvPermisos = new System.Windows.Forms.ListView();
            this.ID_PermisosReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_AgregarPermisos = new System.Windows.Forms.Button();
            this.tbPermisosReporte = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(47, 76);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(464, 31);
            this.cbRoles.TabIndex = 0;
            this.cbRoles.SelectionChangeCommitted += new System.EventHandler(this.cbRoles_SelectionChangeCommitted);
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(47, 204);
            this.cbCampus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(464, 31);
            this.cbCampus.TabIndex = 1;
            this.cbCampus.SelectionChangeCommitted += new System.EventHandler(this.cbCampus_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCampus);
            this.panel1.Controls.Add(this.cbRoles);
            this.panel1.Location = new System.Drawing.Point(63, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 444);
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
            listViewItem2.StateImageIndex = 0;
            this.lvPermisos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvPermisos.Location = new System.Drawing.Point(813, 126);
            this.lvPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvPermisos.Name = "lvPermisos";
            this.lvPermisos.Size = new System.Drawing.Size(486, 649);
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
            this.btnGuardar.Location = new System.Drawing.Point(1162, 787);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_AgregarPermisos
            // 
            this.btn_AgregarPermisos.Location = new System.Drawing.Point(179, 160);
            this.btn_AgregarPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_AgregarPermisos.Name = "btn_AgregarPermisos";
            this.btn_AgregarPermisos.Size = new System.Drawing.Size(244, 82);
            this.btn_AgregarPermisos.TabIndex = 5;
            this.btn_AgregarPermisos.Text = "Agregar Permisos";
            this.btn_AgregarPermisos.UseVisualStyleBackColor = true;
            this.btn_AgregarPermisos.Click += new System.EventHandler(this.btn_AgregarPermisos_Click);
            // 
            // tbPermisosReporte
            // 
            this.tbPermisosReporte.Location = new System.Drawing.Point(60, 78);
            this.tbPermisosReporte.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPermisosReporte.Name = "tbPermisosReporte";
            this.tbPermisosReporte.Size = new System.Drawing.Size(359, 31);
            this.tbPermisosReporte.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbPermisosReporte);
            this.panel2.Controls.Add(this.btn_AgregarPermisos);
            this.panel2.Location = new System.Drawing.Point(63, 538);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 267);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar nuevo boton para el reporte";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvPermisos);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(1, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 826);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1466, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gestonar permisos del usuario para ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimizar.Image = global::NewReportesControlEscolar.Properties.Resources.icon_minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1398, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 57;
            this.btnMinimizar.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1429, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 58;
            // 
            // FrmRPTPermisosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 858);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmRPTPermisosRol";
            this.Text = "FmrRPTPermisosRol";
            this.Load += new System.EventHandler(this.FmrRPTPermisosRol_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
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
        private System.Windows.Forms.Button btn_AgregarPermisos;
        private System.Windows.Forms.TextBox tbPermisosReporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label8;
    }
}