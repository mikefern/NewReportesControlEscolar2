
namespace ProyectoLoboSostenido
{
    partial class FrmReportesAsignarCampusNodos
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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvCampus = new System.Windows.Forms.ListView();
            this.ID_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvNodos = new System.Windows.Forms.TreeView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.lvSeleccionarCampus = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            //this.alumnos_ActasExamenTableAdapter1 = new ProyectoLoboSostenido.ne.Alumnos_ActasExamenTableAdapter();////FG Descomentar esto si se agrega al lobo one
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "listViewGroup1";
            this.lvCampus.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7});
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(368, 38);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(241, 361);
            this.lvCampus.TabIndex = 0;
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
            this.Campus.Width = 176;
            // 
            // tvNodos
            // 
            this.tvNodos.Location = new System.Drawing.Point(24, 38);
            this.tvNodos.Name = "tvNodos";
            this.tvNodos.Size = new System.Drawing.Size(259, 361);
            this.tvNodos.TabIndex = 1;
            this.tvNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvNodos_NodeMouseClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(520, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Campus";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.lvRoles.Enabled = false;
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "listViewGroup1";
            this.lvRoles.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup8});
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(314, 26);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(262, 343);
            this.lvRoles.TabIndex = 3;
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
            this.Rol.Width = 198;
            // 
            // btnGuardarRoles
            // 
            this.btnGuardarRoles.Enabled = false;
            this.btnGuardarRoles.Location = new System.Drawing.Point(458, 378);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(118, 23);
            this.btnGuardarRoles.TabIndex = 4;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // lvSeleccionarCampus
            // 
            this.lvSeleccionarCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Campus_name});
            listViewGroup9.Header = "ListViewGroup";
            listViewGroup9.Name = "listViewGroup1";
            this.lvSeleccionarCampus.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9});
            this.lvSeleccionarCampus.HideSelection = false;
            this.lvSeleccionarCampus.Location = new System.Drawing.Point(3, 26);
            this.lvSeleccionarCampus.Name = "lvSeleccionarCampus";
            this.lvSeleccionarCampus.Size = new System.Drawing.Size(244, 343);
            this.lvSeleccionarCampus.TabIndex = 5;
            this.lvSeleccionarCampus.UseCompatibleStateImageBehavior = false;
            this.lvSeleccionarCampus.View = System.Windows.Forms.View.Details;
            this.lvSeleccionarCampus.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSeleccionarCampus_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Campus_name
            // 
            this.Campus_name.Text = "Campus";
            this.Campus_name.Width = 180;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardarRoles);
            this.panel1.Controls.Add(this.lvSeleccionarCampus);
            this.panel1.Controls.Add(this.lvRoles);
            this.panel1.Location = new System.Drawing.Point(636, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 433);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Campus ya guardados en el nodo";
            // 
            // alumnos_ActasExamenTableAdapter1
            // 
            //this.alumnos_ActasExamenTableAdapter1.ClearBeforeFill = true;//FG Descomentar eso si se agrega al lobo one
            // 
            // FrmReportesAsignarCampusNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tvNodos);
            this.Controls.Add(this.lvCampus);
            this.Name = "FrmReportesAsignarCampusNodos";
            this.Text = "FmrReportesAsignarCampusNodos";
            this.Load += new System.EventHandler(this.FmrReportesAsignarCampusNodos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCampus;
        private System.Windows.Forms.TreeView tvNodos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader ID_Campus;
        private System.Windows.Forms.ColumnHeader Campus;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader ID_Rol;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.Button btnGuardarRoles;
        private System.Windows.Forms.ListView lvSeleccionarCampus;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Campus_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        //private ServerLobosDataSetTableAdapters.Alumnos_ActasExamenTableAdapter alumnos_ActasExamenTableAdapter1; //FG Descomentar esto si se agrega al lobo one
    }
}