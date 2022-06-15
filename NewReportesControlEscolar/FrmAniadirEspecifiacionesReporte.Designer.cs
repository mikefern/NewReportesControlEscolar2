
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
            this.btnGuardarCampus = new System.Windows.Forms.Button();
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardarRVOE = new System.Windows.Forms.Button();
            this.btnUsuariosReportesw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lvReportes
            // 
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Reporte,
            this.Reporte});
            this.lvReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvReportes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvReportes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvReportes.Location = new System.Drawing.Point(3, 60);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(287, 477);
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
            this.Reporte.Width = 221;
            // 
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.lvCampus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(326, 60);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(260, 477);
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
            this.Campus.Width = 196;
            // 
            // lvCampusEspecificos
            // 
            this.lvCampusEspecificos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campus_ID,
            this.NombreCampus});
            this.lvCampusEspecificos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvCampusEspecificos.HideSelection = false;
            this.lvCampusEspecificos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvCampusEspecificos.Location = new System.Drawing.Point(629, 60);
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
            this.lvRVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvRVOE.HideSelection = false;
            this.lvRVOE.Location = new System.Drawing.Point(1215, 60);
            this.lvRVOE.Name = "lvRVOE";
            this.lvRVOE.Size = new System.Drawing.Size(377, 477);
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
            this.RVOE.Width = 312;
            // 
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.lvRoles.Enabled = false;
            this.lvRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(923, 60);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(265, 477);
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
            this.Rol.Width = 201;
            // 
            // btnGuardarCampus
            // 
            this.btnGuardarCampus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCampus.Location = new System.Drawing.Point(466, 553);
            this.btnGuardarCampus.Name = "btnGuardarCampus";
            this.btnGuardarCampus.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarCampus.TabIndex = 5;
            this.btnGuardarCampus.Text = "Guardar Campus";
            this.btnGuardarCampus.UseVisualStyleBackColor = true;
            this.btnGuardarCampus.Click += new System.EventHandler(this.btnGuardarCampus_Click);
            // 
            // btnGuardarRoles
            // 
            this.btnGuardarRoles.Enabled = false;
            this.btnGuardarRoles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRoles.Location = new System.Drawing.Point(1023, 553);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(165, 30);
            this.btnGuardarRoles.TabIndex = 6;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardarRVOE
            // 
            this.btnGuardarRVOE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRVOE.Location = new System.Drawing.Point(1397, 553);
            this.btnGuardarRVOE.Name = "btnGuardarRVOE";
            this.btnGuardarRVOE.Size = new System.Drawing.Size(195, 30);
            this.btnGuardarRVOE.TabIndex = 7;
            this.btnGuardarRVOE.Text = "Guardar RVOE";
            this.btnGuardarRVOE.UseVisualStyleBackColor = true;
            this.btnGuardarRVOE.Click += new System.EventHandler(this.btnGuardarRVOE_Click);
            // 
            // btnUsuariosReportesw
            // 
            this.btnUsuariosReportesw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosReportesw.Location = new System.Drawing.Point(630, 417);
            this.btnUsuariosReportesw.Name = "btnUsuariosReportesw";
            this.btnUsuariosReportesw.Size = new System.Drawing.Size(260, 60);
            this.btnUsuariosReportesw.TabIndex = 8;
            this.btnUsuariosReportesw.Text = "Agregar Restricciones de reportes para un usuario";
            this.btnUsuariosReportesw.UseVisualStyleBackColor = true;
            this.btnUsuariosReportesw.Click += new System.EventHandler(this.btnUsuariosReportesw_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lvReportes);
            this.panel1.Controls.Add(this.btnGuardarCampus);
            this.panel1.Controls.Add(this.btnGuardarRoles);
            this.panel1.Controls.Add(this.btnUsuariosReportesw);
            this.panel1.Controls.Add(this.lvCampus);
            this.panel1.Controls.Add(this.btnGuardarRVOE);
            this.panel1.Controls.Add(this.lvRoles);
            this.panel1.Controls.Add(this.lvCampusEspecificos);
            this.panel1.Controls.Add(this.lvRVOE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 657);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnMinimizar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1624, 32);
            this.panel4.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1587, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 58;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimizar.Image = global::NewReportesControlEscolar.Properties.Resources.icon_minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1555, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 57;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1624, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gestionar Reportes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseDown);
            // 
            // FrmAniadirEspecifiacionesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 657);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAniadirEspecifiacionesReporte";
            this.Text = "FrmAniadirEspecifiacionesReporte";
            this.Load += new System.EventHandler(this.FrmAniadirEspecifiacionesReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label2;
    }
}