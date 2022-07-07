
namespace NewReportesControlEscolar
{
    partial class FrmRPT_RelacionarReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_RelacionarReportes));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnRelacionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDDetalle = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GridViewControl = new System.Windows.Forms.DataGridView();
            this.txtIDControl = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewDetalles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRelacionado = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarRelacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(677, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Relación de Reportes ";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRelacionar
            // 
            this.btnRelacionar.BackColor = System.Drawing.Color.Transparent;
            this.btnRelacionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelacionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRelacionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRelacionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelacionar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRelacionar.ForeColor = System.Drawing.Color.Black;
            this.btnRelacionar.Location = new System.Drawing.Point(4, 399);
            this.btnRelacionar.Name = "btnRelacionar";
            this.btnRelacionar.Size = new System.Drawing.Size(126, 43);
            this.btnRelacionar.TabIndex = 20;
            this.btnRelacionar.Text = "Relacionar";
            this.btnRelacionar.UseVisualStyleBackColor = false;
            this.btnRelacionar.Click += new System.EventHandler(this.btnRelacionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ReportesControlEscolar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(394, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "DetalleArchivoReporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID Reporte Detalle";
            // 
            // txtIDDetalle
            // 
            this.txtIDDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDetalle.Location = new System.Drawing.Point(41, 227);
            this.txtIDDetalle.Name = "txtIDDetalle";
            this.txtIDDetalle.ReadOnly = true;
            this.txtIDDetalle.Size = new System.Drawing.Size(55, 37);
            this.txtIDDetalle.TabIndex = 25;
            this.txtIDDetalle.Text = "";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Location = new System.Drawing.Point(581, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 32);
            this.label8.TabIndex = 19;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GridViewControl
            // 
            this.GridViewControl.AllowUserToAddRows = false;
            this.GridViewControl.AllowUserToDeleteRows = false;
            this.GridViewControl.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewControl.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewControl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewControl.GridColor = System.Drawing.Color.Black;
            this.GridViewControl.Location = new System.Drawing.Point(146, 72);
            this.GridViewControl.MultiSelect = false;
            this.GridViewControl.Name = "GridViewControl";
            this.GridViewControl.ReadOnly = true;
            this.GridViewControl.RowHeadersVisible = false;
            this.GridViewControl.ShowEditingIcon = false;
            this.GridViewControl.Size = new System.Drawing.Size(245, 618);
            this.GridViewControl.TabIndex = 63;
            this.GridViewControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewControl_CellContentClick);
            // 
            // txtIDControl
            // 
            this.txtIDControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDControl.Location = new System.Drawing.Point(41, 136);
            this.txtIDControl.Name = "txtIDControl";
            this.txtIDControl.ReadOnly = true;
            this.txtIDControl.Size = new System.Drawing.Size(55, 37);
            this.txtIDControl.TabIndex = 65;
            this.txtIDControl.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID Reporte Control";
            // 
            // GridViewDetalles
            // 
            this.GridViewDetalles.AllowUserToAddRows = false;
            this.GridViewDetalles.AllowUserToDeleteRows = false;
            this.GridViewDetalles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewDetalles.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewDetalles.GridColor = System.Drawing.Color.Black;
            this.GridViewDetalles.Location = new System.Drawing.Point(397, 72);
            this.GridViewDetalles.MultiSelect = false;
            this.GridViewDetalles.Name = "GridViewDetalles";
            this.GridViewDetalles.ReadOnly = true;
            this.GridViewDetalles.RowHeadersVisible = false;
            this.GridViewDetalles.Size = new System.Drawing.Size(245, 618);
            this.GridViewDetalles.TabIndex = 64;
            this.GridViewDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDetalles_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "ID Relacionado";
            // 
            // txtRelacionado
            // 
            this.txtRelacionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRelacionado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelacionado.Location = new System.Drawing.Point(41, 329);
            this.txtRelacionado.Name = "txtRelacionado";
            this.txtRelacionado.ReadOnly = true;
            this.txtRelacionado.Size = new System.Drawing.Size(55, 37);
            this.txtRelacionado.TabIndex = 68;
            this.txtRelacionado.Text = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(636, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 69;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEliminarRelacion
            // 
            this.btnEliminarRelacion.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarRelacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRelacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEliminarRelacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarRelacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminarRelacion.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarRelacion.Location = new System.Drawing.Point(4, 448);
            this.btnEliminarRelacion.Name = "btnEliminarRelacion";
            this.btnEliminarRelacion.Size = new System.Drawing.Size(126, 43);
            this.btnEliminarRelacion.TabIndex = 70;
            this.btnEliminarRelacion.Text = "Eliminar Relación";
            this.btnEliminarRelacion.UseVisualStyleBackColor = false;
            this.btnEliminarRelacion.Click += new System.EventHandler(this.btnEliminarRelacion_Click);
            // 
            // FrmRPT_RelacionarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 702);
            this.Controls.Add(this.btnEliminarRelacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRelacionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDControl);
            this.Controls.Add(this.GridViewDetalles);
            this.Controls.Add(this.GridViewControl);
            this.Controls.Add(this.txtIDDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRelacionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_RelacionarReportes";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelacionReportes";
            this.Load += new System.EventHandler(this.RelacionReportes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RelacionReportes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRelacionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtIDDetalle;
        private System.Windows.Forms.DataGridView GridViewControl;
        private System.Windows.Forms.RichTextBox txtIDControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewDetalles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtRelacionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarRelacion;
    }
}