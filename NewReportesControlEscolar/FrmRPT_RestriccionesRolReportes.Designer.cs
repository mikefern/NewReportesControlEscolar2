
namespace NewReportesControlEscolar
{
    partial class FrmRPT_RestriccionesRolReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_RestriccionesRolReportes));
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.lvReportes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(20, 262);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(323, 25);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cbUsuarios_SelectionChangeCommitted);
            // 
            // cbCampus
            // 
            this.cbCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Location = new System.Drawing.Point(20, 154);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(323, 25);
            this.cbCampus.TabIndex = 1;
            this.cbCampus.SelectionChangeCommitted += new System.EventHandler(this.cbCampus_SelectionChangeCommitted);
            // 
            // lvReportes
            // 
            this.lvReportes.CheckBoxes = true;
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre});
            this.lvReportes.Enabled = false;
            this.lvReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvReportes.HideSelection = false;
            this.lvReportes.Location = new System.Drawing.Point(432, 39);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(309, 441);
            this.lvReportes.TabIndex = 2;
            this.lvReportes.UseCompatibleStateImageBehavior = false;
            this.lvReportes.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 242;
            // 
            // btGuardar
            // 
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btGuardar.Location = new System.Drawing.Point(148, 356);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 30);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 543);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.cbCampus);
            this.groupBox1.Controls.Add(this.lvReportes);
            this.groupBox1.Controls.Add(this.cbUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(18, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 486);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de campus y usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(497, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Elegir Reporte a Restringir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = " Seleccionar Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Seleccionar Campus";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 39);
            this.panel4.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(750, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 61;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1064, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Restringir la Entrada de Reporte a los Usuarios ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseDown);
            // 
            // FrmRPT_RestriccionesRolReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_RestriccionesRolReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRestriccionesRolesReportes";
            this.Load += new System.EventHandler(this.FrmRestriccionesRolesReportes_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.ListView lvReportes;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}