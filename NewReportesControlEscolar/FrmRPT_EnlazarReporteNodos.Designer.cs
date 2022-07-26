
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
            this.lvReportesNodo = new System.Windows.Forms.ListView();
            this.ID_reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNodoSeleccionado = new System.Windows.Forms.TextBox();
            this.DGV_Reportes = new System.Windows.Forms.DataGridView();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewNodos
            // 
            this.TreeViewNodos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TreeViewNodos.Location = new System.Drawing.Point(36, 84);
            this.TreeViewNodos.Name = "TreeViewNodos";
            this.TreeViewNodos.Size = new System.Drawing.Size(320, 700);
            this.TreeViewNodos.TabIndex = 0;
            this.TreeViewNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodos_NodeMouseClick);
            // 
            // lvReportesNodo
            // 
            this.lvReportesNodo.BackColor = System.Drawing.SystemColors.Window;
            this.lvReportesNodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_reporte,
            this.NombreReporte});
            this.lvReportesNodo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvReportesNodo.HideSelection = false;
            this.lvReportesNodo.Location = new System.Drawing.Point(6, 16);
            this.lvReportesNodo.Name = "lvReportesNodo";
            this.lvReportesNodo.Size = new System.Drawing.Size(437, 184);
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
            this.btnGuardar.Location = new System.Drawing.Point(672, 539);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Datos Reporte";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(400, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "*Solo se pueden relacionar nodos hijo con los reportes,  de preferencia elija un " +
    "reporte por nodo.";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(636, 537);
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
            this.label6.Location = new System.Drawing.Point(138, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Nodos existentes ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvReportesNodo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(400, 592);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 206);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes relacionados al nodo seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNodoSeleccionado);
            this.groupBox1.Controls.Add(this.DGV_Reportes);
            this.groupBox1.Controls.Add(this.txt_Buscador);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(400, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 424);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes existentes para relacionar";
            // 
            // txtNodoSeleccionado
            // 
            this.txtNodoSeleccionado.Enabled = false;
            this.txtNodoSeleccionado.Location = new System.Drawing.Point(7, 23);
            this.txtNodoSeleccionado.Name = "txtNodoSeleccionado";
            this.txtNodoSeleccionado.Size = new System.Drawing.Size(436, 23);
            this.txtNodoSeleccionado.TabIndex = 88;
            this.txtNodoSeleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_Reportes
            // 
            this.DGV_Reportes.AllowUserToAddRows = false;
            this.DGV_Reportes.AllowUserToDeleteRows = false;
            this.DGV_Reportes.AllowUserToResizeColumns = false;
            this.DGV_Reportes.AllowUserToResizeRows = false;
            this.DGV_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Reportes.Location = new System.Drawing.Point(6, 79);
            this.DGV_Reportes.MultiSelect = false;
            this.DGV_Reportes.Name = "DGV_Reportes";
            this.DGV_Reportes.RowHeadersVisible = false;
            this.DGV_Reportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Reportes.Size = new System.Drawing.Size(437, 337);
            this.DGV_Reportes.TabIndex = 87;
            this.DGV_Reportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Reportes_CellContentClick);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.ForeColor = System.Drawing.Color.Silver;
            this.txt_Buscador.Location = new System.Drawing.Point(6, 50);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(437, 23);
            this.txt_Buscador.TabIndex = 86;
            this.txt_Buscador.Text = "Buscador...";
            this.txt_Buscador.Click += new System.EventHandler(this.txt_Buscador_Click);
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscador_KeyPress);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(877, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Relación de Nodo - Reporte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(22, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 729);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 797);
            this.label1.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(867, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 797);
            this.label4.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(10, 819);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(857, 10);
            this.label5.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(842, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 32);
            this.label8.TabIndex = 81;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmRPT_EnlazarReporteNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(877, 829);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TreeViewNodos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_EnlazarReporteNodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmEnlazarReportesNodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewNodos;
        private System.Windows.Forms.ListView lvReportesNodo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader ID_reporte;
        private System.Windows.Forms.ColumnHeader NombreReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.DataGridView DGV_Reportes;
        private System.Windows.Forms.TextBox txtNodoSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}