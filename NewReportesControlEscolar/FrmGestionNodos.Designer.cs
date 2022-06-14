
namespace NewReportesControlEscolar
{
    partial class FrmGestionNodos
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
            this.btn_EliminarNodo = new System.Windows.Forms.Button();
            this.btn_CambiarNombreNodo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreNuevoNodo = new System.Windows.Forms.TextBox();
            this.btn_AñadirNodo = new System.Windows.Forms.Button();
            this.txt_Posicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NodoPadre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDNodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreNodo = new System.Windows.Forms.TextBox();
            this.btn_AñadirNodoRaiz = new System.Windows.Forms.Button();
            this.lvCampus = new System.Windows.Forms.ListView();
            this.ID_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSeleccionarCampus = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoles = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeViewNodos
            // 
            this.TreeViewNodos.AllowDrop = true;
            this.TreeViewNodos.Location = new System.Drawing.Point(22, 51);
            this.TreeViewNodos.Name = "TreeViewNodos";
            this.TreeViewNodos.Size = new System.Drawing.Size(321, 717);
            this.TreeViewNodos.TabIndex = 0;
            this.TreeViewNodos.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeViewNodos_ItemDrag);
            this.TreeViewNodos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewNodos_AfterSelect);
            this.TreeViewNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodos_NodeMouseClick);
            this.TreeViewNodos.Click += new System.EventHandler(this.TreeViewNodos_Click);
            this.TreeViewNodos.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragDrop);
            this.TreeViewNodos.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragEnter);
            this.TreeViewNodos.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragOver);
            this.TreeViewNodos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewNodos_MouseDown);
            // 
            // btn_EliminarNodo
            // 
            this.btn_EliminarNodo.Location = new System.Drawing.Point(837, 182);
            this.btn_EliminarNodo.Name = "btn_EliminarNodo";
            this.btn_EliminarNodo.Size = new System.Drawing.Size(117, 23);
            this.btn_EliminarNodo.TabIndex = 52;
            this.btn_EliminarNodo.Text = "Eliminar Nodo";
            this.btn_EliminarNodo.UseVisualStyleBackColor = true;
            this.btn_EliminarNodo.Click += new System.EventHandler(this.btn_EliminarNodo_Click);
            // 
            // btn_CambiarNombreNodo
            // 
            this.btn_CambiarNombreNodo.Location = new System.Drawing.Point(688, 182);
            this.btn_CambiarNombreNodo.Name = "btn_CambiarNombreNodo";
            this.btn_CambiarNombreNodo.Size = new System.Drawing.Size(117, 23);
            this.btn_CambiarNombreNodo.TabIndex = 51;
            this.btn_CambiarNombreNodo.Text = "Cambiar Nombre";
            this.btn_CambiarNombreNodo.UseVisualStyleBackColor = true;
            this.btn_CambiarNombreNodo.Click += new System.EventHandler(this.btn_CambiarNombreNodo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "NUEVO NOMBRE NODO";
            // 
            // txtNombreNuevoNodo
            // 
            this.txtNombreNuevoNodo.Location = new System.Drawing.Point(411, 156);
            this.txtNombreNuevoNodo.Name = "txtNombreNuevoNodo";
            this.txtNombreNuevoNodo.Size = new System.Drawing.Size(575, 20);
            this.txtNombreNuevoNodo.TabIndex = 49;
            // 
            // btn_AñadirNodo
            // 
            this.btn_AñadirNodo.Location = new System.Drawing.Point(411, 182);
            this.btn_AñadirNodo.Name = "btn_AñadirNodo";
            this.btn_AñadirNodo.Size = new System.Drawing.Size(117, 23);
            this.btn_AñadirNodo.TabIndex = 48;
            this.btn_AñadirNodo.Text = "Añadir nodo";
            this.btn_AñadirNodo.UseVisualStyleBackColor = true;
            this.btn_AñadirNodo.Click += new System.EventHandler(this.btn_AñadirNodo_Click);
            // 
            // txt_Posicion
            // 
            this.txt_Posicion.Location = new System.Drawing.Point(700, 92);
            this.txt_Posicion.Name = "txt_Posicion";
            this.txt_Posicion.ReadOnly = true;
            this.txt_Posicion.Size = new System.Drawing.Size(50, 20);
            this.txt_Posicion.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "POSICION";
            // 
            // txt_NodoPadre
            // 
            this.txt_NodoPadre.Location = new System.Drawing.Point(485, 92);
            this.txt_NodoPadre.Name = "txt_NodoPadre";
            this.txt_NodoPadre.ReadOnly = true;
            this.txt_NodoPadre.Size = new System.Drawing.Size(192, 20);
            this.txt_NodoPadre.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID NODO PADRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "NOMBRE NODO";
            // 
            // txt_IDNodo
            // 
            this.txt_IDNodo.Location = new System.Drawing.Point(411, 92);
            this.txt_IDNodo.Name = "txt_IDNodo";
            this.txt_IDNodo.ReadOnly = true;
            this.txt_IDNodo.Size = new System.Drawing.Size(50, 20);
            this.txt_IDNodo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID NODO";
            // 
            // txt_NombreNodo
            // 
            this.txt_NombreNodo.Location = new System.Drawing.Point(780, 92);
            this.txt_NombreNodo.Name = "txt_NombreNodo";
            this.txt_NombreNodo.ReadOnly = true;
            this.txt_NombreNodo.Size = new System.Drawing.Size(298, 20);
            this.txt_NombreNodo.TabIndex = 40;
            // 
            // btn_AñadirNodoRaiz
            // 
            this.btn_AñadirNodoRaiz.Location = new System.Drawing.Point(544, 182);
            this.btn_AñadirNodoRaiz.Name = "btn_AñadirNodoRaiz";
            this.btn_AñadirNodoRaiz.Size = new System.Drawing.Size(117, 23);
            this.btn_AñadirNodoRaiz.TabIndex = 39;
            this.btn_AñadirNodoRaiz.Text = "Añadir Nodo a Raiz";
            this.btn_AñadirNodoRaiz.UseVisualStyleBackColor = true;
            this.btn_AñadirNodoRaiz.Click += new System.EventHandler(this.btn_AñadirNodoRaiz_Click);
            // 
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(375, 376);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(241, 361);
            this.lvCampus.TabIndex = 55;
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
            // lvSeleccionarCampus
            // 
            this.lvSeleccionarCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Campus_name});
            this.lvSeleccionarCampus.HideSelection = false;
            this.lvSeleccionarCampus.Location = new System.Drawing.Point(654, 376);
            this.lvSeleccionarCampus.Name = "lvSeleccionarCampus";
            this.lvSeleccionarCampus.Size = new System.Drawing.Size(244, 361);
            this.lvSeleccionarCampus.TabIndex = 56;
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
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.lvRoles.Enabled = false;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(935, 376);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(262, 361);
            this.lvRoles.TabIndex = 57;
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
            this.btnGuardarRoles.Location = new System.Drawing.Point(1079, 745);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(118, 23);
            this.btnGuardarRoles.TabIndex = 58;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(527, 745);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar Campus";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(918, 256);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(279, 23);
            this.btnReportes.TabIndex = 60;
            this.btnReportes.Text = "Conectar Reportes con los nodos";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FrmGestionNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 780);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnGuardarRoles);
            this.Controls.Add(this.lvRoles);
            this.Controls.Add(this.lvSeleccionarCampus);
            this.Controls.Add(this.lvCampus);
            this.Controls.Add(this.btn_EliminarNodo);
            this.Controls.Add(this.btn_CambiarNombreNodo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreNuevoNodo);
            this.Controls.Add(this.btn_AñadirNodo);
            this.Controls.Add(this.txt_Posicion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NodoPadre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IDNodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NombreNodo);
            this.Controls.Add(this.btn_AñadirNodoRaiz);
            this.Controls.Add(this.TreeViewNodos);
            this.Name = "FrmGestionNodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Nodos de Reporte Escolar";
            this.Load += new System.EventHandler(this.FrmGestionNodos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewNodos;
        private System.Windows.Forms.Button btn_EliminarNodo;
        private System.Windows.Forms.Button btn_CambiarNombreNodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreNuevoNodo;
        private System.Windows.Forms.Button btn_AñadirNodo;
        private System.Windows.Forms.TextBox txt_Posicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NodoPadre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDNodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreNodo;
        private System.Windows.Forms.Button btn_AñadirNodoRaiz;
        private System.Windows.Forms.ListView lvCampus;
        private System.Windows.Forms.ColumnHeader ID_Campus;
        private System.Windows.Forms.ColumnHeader Campus;
        private System.Windows.Forms.ListView lvSeleccionarCampus;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Campus_name;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader ID_Rol;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.Button btnGuardarRoles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReportes;
    }
}