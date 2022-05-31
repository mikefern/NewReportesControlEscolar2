
namespace ProyectoLoboSostenido
{
    partial class FrmReportesLimitarNodos
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvCampus = new System.Windows.Forms.ListView();
            this.id_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvNodos = new System.Windows.Forms.TreeView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCampus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvCampus);
            this.panel1.Location = new System.Drawing.Point(503, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 222);
            this.panel1.TabIndex = 2;
            // 
            // lvCampus
            // 
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_Campus,
            this.Campus});
            this.lvCampus.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvCampus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvCampus.Location = new System.Drawing.Point(3, 3);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(383, 220);
            this.lvCampus.TabIndex = 3;
            this.lvCampus.UseCompatibleStateImageBehavior = false;
            this.lvCampus.View = System.Windows.Forms.View.Details;
            // 
            // id_Campus
            // 
            this.id_Campus.Text = "ID";
            // 
            // Campus
            // 
            this.Campus.Text = "Campus";
            this.Campus.Width = 318;
            // 
            // tvNodos
            // 
            this.tvNodos.Location = new System.Drawing.Point(44, 75);
            this.tvNodos.Name = "tvNodos";
            this.tvNodos.Size = new System.Drawing.Size(365, 503);
            this.tvNodos.TabIndex = 3;
            this.tvNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvNodos_NodeMouseClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Location = new System.Drawing.Point(239, 584);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Sleccionar Campus";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(503, 351);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 227);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_Rol
            // 
            this.ID_Rol.Text = "ID";
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            this.Rol.Width = 321;
            // 
            // btnCampus
            // 
            this.btnCampus.Location = new System.Drawing.Point(503, 303);
            this.btnCampus.Name = "btnCampus";
            this.btnCampus.Size = new System.Drawing.Size(163, 23);
            this.btnCampus.TabIndex = 6;
            this.btnCampus.Text = "Seleccionar los del campus";
            this.btnCampus.UseVisualStyleBackColor = true;
            this.btnCampus.Click += new System.EventHandler(this.btnCampus_Click);
            // 
            // FrmReportesLimitarNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 641);
            this.Controls.Add(this.btnCampus);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tvNodos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReportesLimitarNodos";
            this.Text = "FrmReportesLimitarNodos";
            this.Load += new System.EventHandler(this.FrmReportesLimitarNodos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvNodos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListView lvCampus;
        private System.Windows.Forms.ColumnHeader id_Campus;
        private System.Windows.Forms.ColumnHeader Campus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Rol;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.Button btnCampus;
    }
}