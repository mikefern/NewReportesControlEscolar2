
namespace ProyectoLoboSostenido
{
    partial class FrmRPT_PermisosBotonReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_PermisosBotonReportes));
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.lvPermisos = new System.Windows.Forms.ListView();
            this.ID_PermisosReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_AgregarPermisos = new System.Windows.Forms.Button();
            this.tbPermisosReporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(18, 79);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(464, 25);
            this.cbRoles.TabIndex = 0;
            this.cbRoles.SelectionChangeCommitted += new System.EventHandler(this.cbRoles_SelectionChangeCommitted);
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(18, 175);
            this.cbCampus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(464, 25);
            this.cbCampus.TabIndex = 1;
            this.cbCampus.SelectionChangeCommitted += new System.EventHandler(this.cbCampus_SelectionChangeCommitted);
            // 
            // lvPermisos
            // 
            this.lvPermisos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvPermisos.CheckBoxes = true;
            this.lvPermisos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_PermisosReporte,
            this.Nombre,
            this.Tipo});
            this.lvPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPermisos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvPermisos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPermisos.Location = new System.Drawing.Point(0, 25);
            this.lvPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvPermisos.Name = "lvPermisos";
            this.lvPermisos.Size = new System.Drawing.Size(326, 485);
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
            this.Nombre.Width = 190;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(105, 515);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_AgregarPermisos
            // 
            this.btn_AgregarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AgregarPermisos.Location = new System.Drawing.Point(145, 189);
            this.btn_AgregarPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_AgregarPermisos.Name = "btn_AgregarPermisos";
            this.btn_AgregarPermisos.Size = new System.Drawing.Size(161, 30);
            this.btn_AgregarPermisos.TabIndex = 5;
            this.btn_AgregarPermisos.Text = "Agregar Permisos";
            this.btn_AgregarPermisos.UseVisualStyleBackColor = true;
            this.btn_AgregarPermisos.Click += new System.EventHandler(this.btn_AgregarPermisos_Click);
            // 
            // tbPermisosReporte
            // 
            this.tbPermisosReporte.Location = new System.Drawing.Point(18, 108);
            this.tbPermisosReporte.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPermisosReporte.Multiline = true;
            this.tbPermisosReporte.Name = "tbPermisosReporte";
            this.tbPermisosReporte.Size = new System.Drawing.Size(464, 25);
            this.tbPermisosReporte.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar nuevo boton para el reporte";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 610);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 49);
            this.label5.TabIndex = 63;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvPermisos);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(579, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 548);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Botones para reporte existentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPermisosReporte);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_AgregarPermisos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 235);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Permisos para manipulación de reportes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRoles);
            this.groupBox1.Controls.Add(this.cbCampus);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 249);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de Rol y Campus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar Campus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Rol"; 
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 32);
            this.panel4.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(889, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 58;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(917, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gestionar Permisos de los Usuarios para Manipular los Reportes ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 72;
            // 
            // FrmRPT_PermisosBotonReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 610);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmRPT_PermisosBotonReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrRPTPermisosRol";
            this.Load += new System.EventHandler(this.FmrRPTPermisosRol_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.ListView lvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader ID_PermisosReporte;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Button btn_AgregarPermisos;
        private System.Windows.Forms.TextBox tbPermisosReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Tipo;
    }
}