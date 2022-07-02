
namespace NewReportesControlEscolar
{
    partial class FrmRPT_ControlNodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_ControlNodos));
            this.TreeViewNodos = new System.Windows.Forms.TreeView();
            this.btn_EliminarNodo = new System.Windows.Forms.Button();
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_CambiarNombreNodo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_PosicionBD = new System.Windows.Forms.TextBox();
            this.btn_igualarPosicion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewNodos
            // 
            this.TreeViewNodos.AllowDrop = true;
            this.TreeViewNodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeViewNodos.Location = new System.Drawing.Point(12, 48);
            this.TreeViewNodos.Name = "TreeViewNodos";
            this.TreeViewNodos.Size = new System.Drawing.Size(324, 688);
            this.TreeViewNodos.TabIndex = 0;
            this.TreeViewNodos.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeViewNodos_ItemDrag);
            this.TreeViewNodos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewNodos_AfterSelect);
            this.TreeViewNodos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodos_NodeMouseClick);
            this.TreeViewNodos.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragDrop);
            this.TreeViewNodos.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragEnter);
            this.TreeViewNodos.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeViewNodos_DragOver);
            this.TreeViewNodos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewNodos_MouseDown);
            // 
            // btn_EliminarNodo
            // 
            this.btn_EliminarNodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarNodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_EliminarNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarNodo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_EliminarNodo.Location = new System.Drawing.Point(1044, 234);
            this.btn_EliminarNodo.Name = "btn_EliminarNodo";
            this.btn_EliminarNodo.Size = new System.Drawing.Size(150, 30);
            this.btn_EliminarNodo.TabIndex = 52;
            this.btn_EliminarNodo.Text = "Eliminar Nodo";
            this.btn_EliminarNodo.UseVisualStyleBackColor = true;
            this.btn_EliminarNodo.Click += new System.EventHandler(this.btn_EliminarNodo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(375, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "NUEVO NOMBRE NODO";
            // 
            // txtNombreNuevoNodo
            // 
            this.txtNombreNuevoNodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevoNodo.Location = new System.Drawing.Point(372, 155);
            this.txtNombreNuevoNodo.Multiline = true;
            this.txtNombreNuevoNodo.Name = "txtNombreNuevoNodo";
            this.txtNombreNuevoNodo.Size = new System.Drawing.Size(350, 30);
            this.txtNombreNuevoNodo.TabIndex = 49;
            this.txtNombreNuevoNodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AñadirNodo
            // 
            this.btn_AñadirNodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AñadirNodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_AñadirNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AñadirNodo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AñadirNodo.Location = new System.Drawing.Point(411, 234);
            this.btn_AñadirNodo.Name = "btn_AñadirNodo";
            this.btn_AñadirNodo.Size = new System.Drawing.Size(150, 30);
            this.btn_AñadirNodo.TabIndex = 48;
            this.btn_AñadirNodo.Text = "Añadir nodo";
            this.btn_AñadirNodo.UseVisualStyleBackColor = true;
            this.btn_AñadirNodo.Click += new System.EventHandler(this.btn_AñadirNodo_Click);
            // 
            // txt_Posicion
            // 
            this.txt_Posicion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Posicion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Posicion.Location = new System.Drawing.Point(679, 80);
            this.txt_Posicion.Multiline = true;
            this.txt_Posicion.Name = "txt_Posicion";
            this.txt_Posicion.ReadOnly = true;
            this.txt_Posicion.Size = new System.Drawing.Size(50, 30);
            this.txt_Posicion.TabIndex = 47;
            this.txt_Posicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(667, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "POSICIÓN  BD";
            // 
            // txt_NodoPadre
            // 
            this.txt_NodoPadre.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NodoPadre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NodoPadre.Location = new System.Drawing.Point(467, 80);
            this.txt_NodoPadre.Multiline = true;
            this.txt_NodoPadre.Name = "txt_NodoPadre";
            this.txt_NodoPadre.ReadOnly = true;
            this.txt_NodoPadre.Size = new System.Drawing.Size(192, 30);
            this.txt_NodoPadre.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(503, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID NODO PADRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(802, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "NOMBRE NODO";
            // 
            // txt_IDNodo
            // 
            this.txt_IDNodo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_IDNodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDNodo.Location = new System.Drawing.Point(372, 80);
            this.txt_IDNodo.Multiline = true;
            this.txt_IDNodo.Name = "txt_IDNodo";
            this.txt_IDNodo.ReadOnly = true;
            this.txt_IDNodo.Size = new System.Drawing.Size(64, 30);
            this.txt_IDNodo.TabIndex = 42;
            this.txt_IDNodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(369, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID NODO";
            // 
            // txt_NombreNodo
            // 
            this.txt_NombreNodo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NombreNodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreNodo.Location = new System.Drawing.Point(805, 80);
            this.txt_NombreNodo.Multiline = true;
            this.txt_NombreNodo.Name = "txt_NombreNodo";
            this.txt_NombreNodo.ReadOnly = true;
            this.txt_NombreNodo.Size = new System.Drawing.Size(389, 30);
            this.txt_NombreNodo.TabIndex = 40;
            // 
            // btn_AñadirNodoRaiz
            // 
            this.btn_AñadirNodoRaiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AñadirNodoRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_AñadirNodoRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AñadirNodoRaiz.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AñadirNodoRaiz.Location = new System.Drawing.Point(623, 234);
            this.btn_AñadirNodoRaiz.Name = "btn_AñadirNodoRaiz";
            this.btn_AñadirNodoRaiz.Size = new System.Drawing.Size(150, 30);
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
            this.lvCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCampus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(372, 305);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(244, 394);
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
            this.lvSeleccionarCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSeleccionarCampus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSeleccionarCampus.HideSelection = false;
            this.lvSeleccionarCampus.Location = new System.Drawing.Point(659, 305);
            this.lvSeleccionarCampus.Name = "lvSeleccionarCampus";
            this.lvSeleccionarCampus.Size = new System.Drawing.Size(244, 394);
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
            this.lvRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRoles.Enabled = false;
            this.lvRoles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(950, 305);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(244, 394);
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
            this.btnGuardarRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRoles.Enabled = false;
            this.btnGuardarRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarRoles.Location = new System.Drawing.Point(1008, 732);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(150, 30);
            this.btnGuardarRoles.TabIndex = 58;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(416, 734);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 30);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar Campus";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnReportes.Location = new System.Drawing.Point(955, 155);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(239, 30);
            this.btnReportes.TabIndex = 60;
            this.btnReportes.Text = "Conectar Reportes con los nodos";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(1214, 32);
            this.lbl_Titulo.TabIndex = 61;
            this.lbl_Titulo.Text = "Control de Nodos ";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Titulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.TreeViewNodos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 748);
            this.panel1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(118, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nodos Existentes ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 708);
            this.button2.TabIndex = 72;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1177, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 32);
            this.label8.TabIndex = 70;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_CambiarNombreNodo
            // 
            this.btn_CambiarNombreNodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CambiarNombreNodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_CambiarNombreNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CambiarNombreNodo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_CambiarNombreNodo.Location = new System.Drawing.Point(841, 234);
            this.btn_CambiarNombreNodo.Name = "btn_CambiarNombreNodo";
            this.btn_CambiarNombreNodo.Size = new System.Drawing.Size(150, 30);
            this.btn_CambiarNombreNodo.TabIndex = 51;
            this.btn_CambiarNombreNodo.Text = "Cambiar Nombre";
            this.btn_CambiarNombreNodo.UseVisualStyleBackColor = true;
            this.btn_CambiarNombreNodo.Click += new System.EventHandler(this.btn_CambiarNombreNodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(586, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(805, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1008, 232);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(380, 732);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 75;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(919, 155);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 76;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(972, 730);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 77;
            this.pictureBox7.TabStop = false;
            // 
            // txt_PosicionBD
            // 
            this.txt_PosicionBD.BackColor = System.Drawing.SystemColors.Window;
            this.txt_PosicionBD.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PosicionBD.Location = new System.Drawing.Point(735, 80);
            this.txt_PosicionBD.Multiline = true;
            this.txt_PosicionBD.Name = "txt_PosicionBD";
            this.txt_PosicionBD.ReadOnly = true;
            this.txt_PosicionBD.Size = new System.Drawing.Size(50, 30);
            this.txt_PosicionBD.TabIndex = 78;
            this.txt_PosicionBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_igualarPosicion
            // 
            this.btn_igualarPosicion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igualarPosicion.Location = new System.Drawing.Point(679, 116);
            this.btn_igualarPosicion.Name = "btn_igualarPosicion";
            this.btn_igualarPosicion.Size = new System.Drawing.Size(106, 23);
            this.btn_igualarPosicion.TabIndex = 79;
            this.btn_igualarPosicion.Text = "Igualar Posicion";
            this.btn_igualarPosicion.UseVisualStyleBackColor = true;
            this.btn_igualarPosicion.Visible = false;
            this.btn_igualarPosicion.Click += new System.EventHandler(this.btn_igualarPosicion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Campus Actuales para el nodo seleccionado";
            // 
            // FrmRPT_ControlNodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1214, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_igualarPosicion);
            this.Controls.Add(this.txt_PosicionBD);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Titulo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_ControlNodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Nodos de Reporte Escolar";
            this.Load += new System.EventHandler(this.FrmRPT_ControlNodos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGestionNodos_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewNodos;
        private System.Windows.Forms.Button btn_EliminarNodo;
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
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_CambiarNombreNodo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txt_PosicionBD;
        private System.Windows.Forms.Button btn_igualarPosicion;
        private System.Windows.Forms.Label label1;
    }
}