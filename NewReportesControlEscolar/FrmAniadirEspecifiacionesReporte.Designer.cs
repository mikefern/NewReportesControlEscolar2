
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAniadirEspecifiacionesReporte));
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUsuariosReportesw = new System.Windows.Forms.Button();
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardarCampus = new System.Windows.Forms.Button();
            this.btnGuardarRVOE = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvReportes
            // 
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Reporte,
            this.Reporte});
            this.lvReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvReportes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvReportes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvReportes.Location = new System.Drawing.Point(9, 19);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(279, 403);
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
            this.Reporte.Width = 264;
            // 
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.lvCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(6, 19);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(279, 403);
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
            this.lvCampusEspecificos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCampusEspecificos.HideSelection = false;
            this.lvCampusEspecificos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvCampusEspecificos.Location = new System.Drawing.Point(6, 19);
            this.lvCampusEspecificos.Name = "lvCampusEspecificos";
            this.lvCampusEspecificos.Size = new System.Drawing.Size(279, 403);
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
            this.lvRVOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRVOE.HideSelection = false;
            this.lvRVOE.Location = new System.Drawing.Point(9, 19);
            this.lvRVOE.Name = "lvRVOE";
            this.lvRVOE.Size = new System.Drawing.Size(279, 403);
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
            this.lvRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(291, 19);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(279, 403);
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
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(922, 32);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "Añadir Especificaciones de Reporte";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(882, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 70;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvReportes);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 428);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elección de reporte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCampus);
            this.groupBox2.Controls.Add(this.lvRoles);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(328, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 428);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de Permisos en Campus y Roles";
            // 
            // btnUsuariosReportesw
            // 
            this.btnUsuariosReportesw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuariosReportesw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUsuariosReportesw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosReportesw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUsuariosReportesw.Location = new System.Drawing.Point(37, 767);
            this.btnUsuariosReportesw.Name = "btnUsuariosReportesw";
            this.btnUsuariosReportesw.Size = new System.Drawing.Size(213, 50);
            this.btnUsuariosReportesw.TabIndex = 8;
            this.btnUsuariosReportesw.Text = "Agregar Restricciones a usuario";
            this.btnUsuariosReportesw.UseVisualStyleBackColor = true;
            this.btnUsuariosReportesw.Click += new System.EventHandler(this.btnUsuariosReportesw_Click);
            // 
            // btnGuardarRoles
            // 
            this.btnGuardarRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarRoles.Location = new System.Drawing.Point(37, 510);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(213, 50);
            this.btnGuardarRoles.TabIndex = 6;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardarCampus
            // 
            this.btnGuardarCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCampus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCampus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarCampus.Location = new System.Drawing.Point(37, 595);
            this.btnGuardarCampus.Name = "btnGuardarCampus";
            this.btnGuardarCampus.Size = new System.Drawing.Size(213, 50);
            this.btnGuardarCampus.TabIndex = 5;
            this.btnGuardarCampus.Text = "Guardar Campus";
            this.btnGuardarCampus.UseVisualStyleBackColor = true;
            this.btnGuardarCampus.Click += new System.EventHandler(this.btnGuardarCampus_Click);
            // 
            // btnGuardarRVOE
            // 
            this.btnGuardarRVOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRVOE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarRVOE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarRVOE.Location = new System.Drawing.Point(37, 683);
            this.btnGuardarRVOE.Name = "btnGuardarRVOE";
            this.btnGuardarRVOE.Size = new System.Drawing.Size(213, 50);
            this.btnGuardarRVOE.TabIndex = 7;
            this.btnGuardarRVOE.Text = "Guardar RVOE";
            this.btnGuardarRVOE.UseVisualStyleBackColor = true;
            this.btnGuardarRVOE.Click += new System.EventHandler(this.btnGuardarRVOE_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvCampusEspecificos);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(319, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 428);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ver Campus asignados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvRVOE);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(619, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 428);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elección de RVOE según el Campus";
            // 
            // FrmAniadirEspecifiacionesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(922, 903);
            this.Controls.Add(this.btnGuardarRVOE);
            this.Controls.Add(this.btnGuardarRoles);
            this.Controls.Add(this.btnGuardarCampus);
            this.Controls.Add(this.btnUsuariosReportesw);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAniadirEspecifiacionesReporte";
            this.Opacity = 0.95D;
            this.Text = "FrmAniadirEspecifiacionesReporte";
            this.Load += new System.EventHandler(this.FrmAniadirEspecifiacionesReporte_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAniadirEspecifiacionesReporte_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader Campus_ID;
        private System.Windows.Forms.ColumnHeader NombreCampus;
        private System.Windows.Forms.ColumnHeader ID_RVOE;
        private System.Windows.Forms.ColumnHeader RVOE;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUsuariosReportesw;
        private System.Windows.Forms.Button btnGuardarRoles;
        private System.Windows.Forms.Button btnGuardarCampus;
        private System.Windows.Forms.Button btnGuardarRVOE;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}