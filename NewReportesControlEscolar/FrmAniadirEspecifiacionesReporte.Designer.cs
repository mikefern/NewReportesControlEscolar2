
namespace NewReportesControlEscolar
{
    partial class FrmAniadirEspecifiacionesReporte
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lvReportes = new System.Windows.Forms.ListView();
            this.ID_Reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCampus = new System.Windows.Forms.ListView();
            this.ID_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCampusEspecificos = new System.Windows.Forms.ListView();
            this.Campus_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCampus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRVOE = new System.Windows.Forms.ListView();
            this.ID_RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoles = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarCampus = new System.Windows.Forms.Button();
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardarRVOE = new System.Windows.Forms.Button();
            this.btnUsuariosReportesw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvReportes
            // 
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Reporte,
            this.Reporte});
            this.lvReportes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvReportes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvReportes.Location = new System.Drawing.Point(12, 30);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(281, 477);
            this.lvReportes.TabIndex = 0;
            this.lvReportes.UseCompatibleStateImageBehavior = false;
            this.lvReportes.View = System.Windows.Forms.View.Details;
            this.lvReportes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvReportes_ItemSelectionChanged);
            // 
            // ID_Reporte
            // 
            this.ID_Reporte.Text = "ID";
            // 
            // Reporte
            // 
            this.Reporte.Text = "Nombre";
            this.Reporte.Width = 219;
            // 
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(299, 30);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(279, 477);
            this.lvCampus.TabIndex = 1;
            this.lvCampus.UseCompatibleStateImageBehavior = false;
            this.lvCampus.View = System.Windows.Forms.View.Details;
            // 
            // ID_Campus
            // 
            this.ID_Campus.Text = "ID";
            // 
            // Campus
            // 
            this.Campus.Text = "Campus";
            this.Campus.Width = 212;
            // 
            // lvCampusEspecificos
            // 
            this.lvCampusEspecificos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campus_ID,
            this.NombreCampus});
            this.lvCampusEspecificos.HideSelection = false;
            this.lvCampusEspecificos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvCampusEspecificos.Location = new System.Drawing.Point(916, 30);
            this.lvCampusEspecificos.Name = "lvCampusEspecificos";
            this.lvCampusEspecificos.Size = new System.Drawing.Size(261, 340);
            this.lvCampusEspecificos.TabIndex = 2;
            this.lvCampusEspecificos.UseCompatibleStateImageBehavior = false;
            this.lvCampusEspecificos.View = System.Windows.Forms.View.Details;
            this.lvCampusEspecificos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCampusEspecificos_ItemSelectionChanged);
            // 
            // Campus_ID
            // 
            this.Campus_ID.Text = "ID";
            // 
            // NombreCampus
            // 
            this.NombreCampus.Text = "Campus";
            this.NombreCampus.Width = 196;
            // 
            // lvRVOE
            // 
            this.lvRVOE.CheckBoxes = true;
            this.lvRVOE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_RVOE,
            this.RVOE});
            this.lvRVOE.HideSelection = false;
            this.lvRVOE.Location = new System.Drawing.Point(1241, 30);
            this.lvRVOE.Name = "lvRVOE";
            this.lvRVOE.Size = new System.Drawing.Size(365, 477);
            this.lvRVOE.TabIndex = 3;
            this.lvRVOE.UseCompatibleStateImageBehavior = false;
            this.lvRVOE.View = System.Windows.Forms.View.Details;
            // 
            // ID_RVOE
            // 
            this.ID_RVOE.Text = "ID";
            // 
            // RVOE
            // 
            this.RVOE.Text = "RVOE";
            this.RVOE.Width = 299;
            // 
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(622, 30);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(248, 477);
            this.lvRoles.TabIndex = 4;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // ID_Rol
            // 
            this.ID_Rol.Text = "ID";
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            this.Rol.Width = 184;
            // 
            // btnGuardarCampus
            // 
            this.btnGuardarCampus.Location = new System.Drawing.Point(442, 539);
            this.btnGuardarCampus.Name = "btnGuardarCampus";
            this.btnGuardarCampus.Size = new System.Drawing.Size(116, 23);
            this.btnGuardarCampus.TabIndex = 5;
            this.btnGuardarCampus.Text = "Guardar Campus";
            this.btnGuardarCampus.UseVisualStyleBackColor = true;
            this.btnGuardarCampus.Click += new System.EventHandler(this.btnGuardarCampus_Click);
            // 
            // btnGuardarRoles
            // 
            this.btnGuardarRoles.Location = new System.Drawing.Point(741, 539);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(116, 23);
            this.btnGuardarRoles.TabIndex = 6;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardarRVOE
            // 
            this.btnGuardarRVOE.Location = new System.Drawing.Point(1453, 539);
            this.btnGuardarRVOE.Name = "btnGuardarRVOE";
            this.btnGuardarRVOE.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRVOE.TabIndex = 7;
            this.btnGuardarRVOE.Text = "Guardar RVOE";
            this.btnGuardarRVOE.UseVisualStyleBackColor = true;
            this.btnGuardarRVOE.Click += new System.EventHandler(this.btnGuardarRVOE_Click);
            // 
            // btnUsuariosReportesw
            // 
            this.btnUsuariosReportesw.Location = new System.Drawing.Point(962, 503);
            this.btnUsuariosReportesw.Name = "btnUsuariosReportesw";
            this.btnUsuariosReportesw.Size = new System.Drawing.Size(196, 59);
            this.btnUsuariosReportesw.TabIndex = 8;
            this.btnUsuariosReportesw.Text = "Agregar Restricciones de reportes para un usuario";
            this.btnUsuariosReportesw.UseVisualStyleBackColor = true;
            this.btnUsuariosReportesw.Click += new System.EventHandler(this.btnUsuariosReportesw_Click);
            // 
            // FrmAniadirEspecifiacionesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 580);
            this.Controls.Add(this.btnUsuariosReportesw);
            this.Controls.Add(this.btnGuardarRVOE);
            this.Controls.Add(this.btnGuardarRoles);
            this.Controls.Add(this.btnGuardarCampus);
            this.Controls.Add(this.lvRoles);
            this.Controls.Add(this.lvRVOE);
            this.Controls.Add(this.lvCampusEspecificos);
            this.Controls.Add(this.lvCampus);
            this.Controls.Add(this.lvReportes);
            this.Name = "FrmAniadirEspecifiacionesReporte";
            this.Text = "FrmAniadirEspecifiacionesReporte";
            this.Load += new System.EventHandler(this.FrmAniadirEspecifiacionesReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReportes;
        private System.Windows.Forms.ListView lvCampus;
        private System.Windows.Forms.ListView lvCampusEspecificos;
        private System.Windows.Forms.ListView lvRVOE;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader ID_Rol;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.ColumnHeader ID_Campus;
        private System.Windows.Forms.ColumnHeader Campus;
        private System.Windows.Forms.ColumnHeader ID_Reporte;
        private System.Windows.Forms.ColumnHeader Reporte;
        private System.Windows.Forms.Button btnGuardarCampus;
        private System.Windows.Forms.Button btnGuardarRoles;
        private System.Windows.Forms.ColumnHeader Campus_ID;
        private System.Windows.Forms.ColumnHeader NombreCampus;
        private System.Windows.Forms.Button btnGuardarRVOE;
        private System.Windows.Forms.ColumnHeader ID_RVOE;
        private System.Windows.Forms.ColumnHeader RVOE;
        private System.Windows.Forms.Button btnUsuariosReportesw;
    }
}