
namespace NewReportesControlEscolar
{
    partial class FrmEnlazarReportesNodos
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
            this.TreeViewNodos = new System.Windows.Forms.TreeView();
            this.lvReportes = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReportesNodo = new System.Windows.Forms.ListView();
            this.ID_reporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreReporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeViewNodos
            // 
            this.TreeViewNodos.Location = new System.Drawing.Point(12, 12);
            this.TreeViewNodos.Name = "TreeViewNodos";
            this.TreeViewNodos.Size = new System.Drawing.Size(275, 624);
            this.TreeViewNodos.TabIndex = 0;
            this.TreeViewNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodos_NodeMouseClick);
            // 
            // lvReportes
            // 
            this.lvReportes.CheckBoxes = true;
            this.lvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Reporte});
            this.lvReportes.HideSelection = false;
            this.lvReportes.Location = new System.Drawing.Point(351, 12);
            this.lvReportes.Name = "lvReportes";
            this.lvReportes.Size = new System.Drawing.Size(437, 405);
            this.lvReportes.TabIndex = 1;
            this.lvReportes.UseCompatibleStateImageBehavior = false;
            this.lvReportes.View = System.Windows.Forms.View.Details;
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
            this.lvReportesNodo.HideSelection = false;
            this.lvReportesNodo.Location = new System.Drawing.Point(351, 474);
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
            this.btnGuardar.Location = new System.Drawing.Point(351, 438);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Datos reporte";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmEnlazarReportesNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lvReportesNodo);
            this.Controls.Add(this.lvReportes);
            this.Controls.Add(this.TreeViewNodos);
            this.Name = "FrmEnlazarReportesNodos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmEnlazarReportesNodos_Load);
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
    }
}