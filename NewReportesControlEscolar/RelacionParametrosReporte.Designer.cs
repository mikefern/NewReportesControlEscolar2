﻿
namespace NewReportesControlEscolar
{
    partial class RelacionParametrosReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelacionParametrosReporte));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreReporte = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GridViewDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDReporte = new System.Windows.Forms.RichTextBox();
            this.ID_Parametro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewParametros = new System.Windows.Forms.ListView();
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
            this.lbltitulo.Size = new System.Drawing.Size(560, 32);
            this.lbltitulo.TabIndex = 19;
            this.lbltitulo.Text = "Relación de Parámetros de Reportes";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(527, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 32);
            this.label8.TabIndex = 20;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre Reporte";
            // 
            // txtNombreReporte
            // 
            this.txtNombreReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreReporte.Location = new System.Drawing.Point(15, 61);
            this.txtNombreReporte.Name = "txtNombreReporte";
            this.txtNombreReporte.Size = new System.Drawing.Size(325, 38);
            this.txtNombreReporte.TabIndex = 22;
            this.txtNombreReporte.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(457, 62);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // GridViewDetalles
            // 
            this.GridViewDetalles.AllowUserToAddRows = false;
            this.GridViewDetalles.AllowUserToDeleteRows = false;
            this.GridViewDetalles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewDetalles.GridColor = System.Drawing.Color.Black;
            this.GridViewDetalles.Location = new System.Drawing.Point(15, 118);
            this.GridViewDetalles.MultiSelect = false;
            this.GridViewDetalles.Name = "GridViewDetalles";
            this.GridViewDetalles.RowHeadersVisible = false;
            this.GridViewDetalles.Size = new System.Drawing.Size(234, 413);
            this.GridViewDetalles.TabIndex = 65;
            this.GridViewDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDetalles_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(368, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "IDReporte";
            // 
            // txtIDReporte
            // 
            this.txtIDReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDReporte.Location = new System.Drawing.Point(371, 62);
            this.txtIDReporte.Name = "txtIDReporte";
            this.txtIDReporte.Size = new System.Drawing.Size(64, 38);
            this.txtIDReporte.TabIndex = 75;
            this.txtIDReporte.Text = "";
            // 
            // ID_Parametro
            // 
            this.ID_Parametro.Text = "ID_Parametro";
            this.ID_Parametro.Width = 78;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 121;
            // 
            // listViewParametros
            // 
            this.listViewParametros.AutoArrange = false;
            this.listViewParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewParametros.CheckBoxes = true;
            this.listViewParametros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Parametro,
            this.Nombre});
            this.listViewParametros.HideSelection = false;
            this.listViewParametros.Location = new System.Drawing.Point(314, 118);
            this.listViewParametros.Name = "listViewParametros";
            this.listViewParametros.Size = new System.Drawing.Size(218, 413);
            this.listViewParametros.TabIndex = 76;
            this.listViewParametros.UseCompatibleStateImageBehavior = false;
            this.listViewParametros.View = System.Windows.Forms.View.Details;
            // 
            // RelacionParametrosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 543);
            this.Controls.Add(this.listViewParametros);
            this.Controls.Add(this.txtIDReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewDetalles);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelacionParametrosReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                      ";
            this.Load += new System.EventHandler(this.RelacionParametrosReporte_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RelacionParametrosReporte_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNombreReporte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView GridViewDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtIDReporte;
        private System.Windows.Forms.ColumnHeader ID_Parametro;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ListView listViewParametros;
    }
}