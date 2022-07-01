
namespace NewReportesControlEscolar
{
    partial class FrmRPT_EnlazarReporteNodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_EnlazarReporteNodos));
            this.TreeViewNodos = new System.Windows.Forms.TreeView();
            this.lvReportes = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReportesNodo = new System.Windows.Forms.ListView();
            this.ID_reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewNodos
            // 
            this.TreeViewNodos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TreeViewNodos.Location = new System.Drawing.Point(26, 76);
            this.TreeViewNodos.Name = "TreeViewNodos";
            this.TreeViewNodos.Size = new System.Drawing.Size(320, 686);
            this.TreeViewNodos.TabIndex = 0;
            this.TreeViewNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodos_NodeMouseClick);
            // 
            // lvReportes
            // 
            this.lvReportes.CheckBoxes = true;
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Reporte});
            this.lvReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvReportes.HideSelection = false;
            this.lvReportes.Location = new System.Drawing.Point(6, 22);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(437, 396);
            this.lvReportes.TabIndex = 1;
            this.lvReportes.UseCompatibleStateImageBehavior = false;
            this.lvReportes.View = System.Windows.Forms.View.Details;
            this.lvReportes.SelectedIndexChanged += new System.EventHandler(this.lvReportes_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Reporte
            // 
            this.Reporte.Text = "Reporte";
            this.Reporte.Width = 270;
            // 
            // lvReportesNodo
            // 
            this.lvReportesNodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_reporte,
            this.NombreReporte});
            this.lvReportesNodo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvReportesNodo.HideSelection = false;
            this.lvReportesNodo.Location = new System.Drawing.Point(6, 16);
            this.lvReportesNodo.Name = "lvReportesNodo";
            this.lvReportesNodo.Size = new System.Drawing.Size(437, 162);
            this.lvReportesNodo.TabIndex = 2;
            this.lvReportesNodo.UseCompatibleStateImageBehavior = false;
            this.lvReportesNodo.View = System.Windows.Forms.View.Details;
            // 
            // ID_reporte
            // 
            this.ID_reporte.Text = "ID";
            // 
            // NombreReporte
            // 
            this.NombreReporte.Text = "Reporte";
            this.NombreReporte.Width = 371;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(662, 531);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Datos Reporte";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TreeViewNodos);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 781);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(390, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 38);
            this.label3.TabIndex = 77;
            this.label3.Text = "*Solo se pueden relacionar nodos hijo con los reportes,  de preferencia elija un " +
    "reporte por nodo.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(626, 529);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(128, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Nodos existentes ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvReportesNodo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(390, 584);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 185);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes relacionados al nodo seleccionado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvReportes);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(390, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 424);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes existentes para relacionar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 32);
            this.panel4.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(826, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 59;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(852, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Relación de nodo con el reporte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 708);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmEnlazarReportesNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnlazarReportesNodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmEnlazarReportesNodos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewNodos;
        private System.Windows.Forms.ListView lvReportes;
        private System.Windows.Forms.ListView lvReportesNodo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Reporte;
        private System.Windows.Forms.ColumnHeader ID_reporte;
        private System.Windows.Forms.ColumnHeader NombreReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
    }
}