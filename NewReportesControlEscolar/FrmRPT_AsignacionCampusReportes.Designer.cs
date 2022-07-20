
namespace NewReportesControlEscolar
{
    partial class FrmRPT_AsignacionCampusReportes
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_AsignacionCampusReportes));
            this.LV_Campus = new System.Windows.Forms.ListView();
            this.ID_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_CampusEspecificos = new System.Windows.Forms.ListView();
            this.Campus_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCampus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_RVOE = new System.Windows.Forms.ListView();
            this.ID_RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_Roles = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarCampus = new System.Windows.Forms.Button();
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardarRVOE = new System.Windows.Forms.Button();
            this.btnUsuariosReportesw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.DGV_Reportes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_BuscadorRVOE = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reportes)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Campus
            // 
            this.LV_Campus.CheckBoxes = true;
            this.LV_Campus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.LV_Campus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LV_Campus.HideSelection = false;
            this.LV_Campus.Location = new System.Drawing.Point(6, 24);
            this.LV_Campus.Name = "LV_Campus";
            this.LV_Campus.Size = new System.Drawing.Size(294, 364);
            this.LV_Campus.TabIndex = 1;
            this.LV_Campus.UseCompatibleStateImageBehavior = false;
            this.LV_Campus.View = System.Windows.Forms.View.Details;
            // 
            // ID_Campus
            // 
            this.ID_Campus.Text = "ID";
            // 
            // Campus
            // 
            this.Campus.Text = "Campus";
            this.Campus.Width = 196;
            // 
            // LV_CampusEspecificos
            // 
            this.LV_CampusEspecificos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campus_ID,
            this.NombreCampus});
            this.LV_CampusEspecificos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LV_CampusEspecificos.HideSelection = false;
            this.LV_CampusEspecificos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LV_CampusEspecificos.Location = new System.Drawing.Point(318, 22);
            this.LV_CampusEspecificos.Name = "LV_CampusEspecificos";
            this.LV_CampusEspecificos.Size = new System.Drawing.Size(373, 366);
            this.LV_CampusEspecificos.TabIndex = 2;
            this.LV_CampusEspecificos.UseCompatibleStateImageBehavior = false;
            this.LV_CampusEspecificos.View = System.Windows.Forms.View.Details;
            this.LV_CampusEspecificos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCampusEspecificos_ItemSelectionChanged);
            // 
            // Campus_ID
            // 
            this.Campus_ID.Text = "ID";
            // 
            // NombreCampus
            // 
            this.NombreCampus.Text = "Campus";
            this.NombreCampus.Width = 196;
            // 
            // LV_RVOE
            // 
            this.LV_RVOE.CheckBoxes = true;
            this.LV_RVOE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_RVOE,
            this.RVOE});
            this.LV_RVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LV_RVOE.HideSelection = false;
            this.LV_RVOE.Location = new System.Drawing.Point(6, 50);
            this.LV_RVOE.Name = "LV_RVOE";
            this.LV_RVOE.Size = new System.Drawing.Size(373, 350);
            this.LV_RVOE.TabIndex = 3;
            this.LV_RVOE.UseCompatibleStateImageBehavior = false;
            this.LV_RVOE.View = System.Windows.Forms.View.Details;
            this.LV_RVOE.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LV_RVOE_ItemChecked);
            this.LV_RVOE.SelectedIndexChanged += new System.EventHandler(this.LV_RVOE_SelectedIndexChanged);
            // 
            // ID_RVOE
            // 
            this.ID_RVOE.Text = "ID";
            // 
            // RVOE
            // 
            this.RVOE.Text = "RVOE";
            this.RVOE.Width = 312;
            // 
            // LV_Roles
            // 
            this.LV_Roles.CheckBoxes = true;
            this.LV_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.LV_Roles.Enabled = false;
            this.LV_Roles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LV_Roles.HideSelection = false;
            this.LV_Roles.Location = new System.Drawing.Point(6, 22);
            this.LV_Roles.Name = "LV_Roles";
            this.LV_Roles.Size = new System.Drawing.Size(294, 378);
            this.LV_Roles.TabIndex = 4;
            this.LV_Roles.UseCompatibleStateImageBehavior = false;
            this.LV_Roles.View = System.Windows.Forms.View.Details;
            // 
            // ID_Rol
            // 
            this.ID_Rol.Text = "ID";
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            this.Rol.Width = 201;
            // 
            // btnGuardarCampus
            // 
            this.btnGuardarCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCampus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCampus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarCampus.Location = new System.Drawing.Point(37, 392);
            this.btnGuardarCampus.Name = "btnGuardarCampus";
            this.btnGuardarCampus.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarCampus.TabIndex = 5;
            this.btnGuardarCampus.Text = "Guardar Campus";
            this.btnGuardarCampus.UseVisualStyleBackColor = true;
            this.btnGuardarCampus.Click += new System.EventHandler(this.btnGuardarCampus_Click);
            // 
            // btnGuardarRoles
            // 
            this.btnGuardarRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRoles.Enabled = false;
            this.btnGuardarRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarRoles.Location = new System.Drawing.Point(37, 403);
            this.btnGuardarRoles.Name = "btnGuardarRoles";
            this.btnGuardarRoles.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarRoles.TabIndex = 6;
            this.btnGuardarRoles.Text = "Guardar Roles";
            this.btnGuardarRoles.UseVisualStyleBackColor = true;
            this.btnGuardarRoles.Click += new System.EventHandler(this.btnGuardarRoles_Click);
            // 
            // btnGuardarRVOE
            // 
            this.btnGuardarRVOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRVOE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardarRVOE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarRVOE.Location = new System.Drawing.Point(37, 402);
            this.btnGuardarRVOE.Name = "btnGuardarRVOE";
            this.btnGuardarRVOE.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarRVOE.TabIndex = 7;
            this.btnGuardarRVOE.Text = "Guardar RVOE";
            this.btnGuardarRVOE.UseVisualStyleBackColor = true;
            this.btnGuardarRVOE.Click += new System.EventHandler(this.btnGuardarRVOE_Click);
            // 
            // btnUsuariosReportesw
            // 
            this.btnUsuariosReportesw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuariosReportesw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUsuariosReportesw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosReportesw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUsuariosReportesw.Location = new System.Drawing.Point(60, 934);
            this.btnUsuariosReportesw.Name = "btnUsuariosReportesw";
            this.btnUsuariosReportesw.Size = new System.Drawing.Size(268, 30);
            this.btnUsuariosReportesw.TabIndex = 8;
            this.btnUsuariosReportesw.Text = "Asignación de Restricciones al Usuario";
            this.btnUsuariosReportesw.UseVisualStyleBackColor = true;
            this.btnUsuariosReportesw.Click += new System.EventHandler(this.btnUsuariosReportesw_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_Buscador);
            this.panel1.Controls.Add(this.DGV_Reportes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnUsuariosReportesw);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 976);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "Proceso Automático Rol Campus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.ForeColor = System.Drawing.Color.Silver;
            this.txt_Buscador.Location = new System.Drawing.Point(38, 64);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(286, 20);
            this.txt_Buscador.TabIndex = 85;
            this.txt_Buscador.Text = "Buscador...";
            this.txt_Buscador.Click += new System.EventHandler(this.txt_Buscador_Click);
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged_1);
            this.txt_Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscador_KeyPress);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // DGV_Reportes
            // 
            this.DGV_Reportes.AllowUserToAddRows = false;
            this.DGV_Reportes.AllowUserToDeleteRows = false;
            this.DGV_Reportes.AllowUserToResizeRows = false;
            this.DGV_Reportes.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Reportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Reportes.Location = new System.Drawing.Point(38, 101);
            this.DGV_Reportes.MultiSelect = false;
            this.DGV_Reportes.Name = "DGV_Reportes";
            this.DGV_Reportes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Reportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Reportes.RowHeadersVisible = false;
            this.DGV_Reportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_Reportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Reportes.Size = new System.Drawing.Size(286, 564);
            this.DGV_Reportes.TabIndex = 84;
            this.DGV_Reportes.SelectionChanged += new System.EventHandler(this.DGV_Reportes_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.Location = new System.Drawing.Point(110, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Reportes Existentes ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 587);
            this.button1.TabIndex = 82;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(33, 847);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 36);
            this.label7.TabIndex = 81;
            this.label7.Text = "Paso 4. Para asignar el RVOE haga click en el ID del Campus en el segundo apartad" +
    "o y guarde.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 796);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 36);
            this.label5.TabIndex = 80;
            this.label5.Text = "Paso 3. Asigne los roles que pueden ver el reporte  en los campus seleccionados y" +
    " guarde.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 36);
            this.label4.TabIndex = 79;
            this.label4.Text = "Paso 2. En el apartado asiganción de campus elija  el o los Campus y guarde.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 36);
            this.label3.TabIndex = 78;
            this.label3.Text = "Paso 1. Elija el reporte al que asignará el Campus y Rol.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_BuscadorRVOE);
            this.groupBox4.Controls.Add(this.btnGuardarRVOE);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.LV_RVOE);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(674, 498);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 438);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asignación de RVOE según el Campus";
            // 
            // txt_BuscadorRVOE
            // 
            this.txt_BuscadorRVOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscadorRVOE.ForeColor = System.Drawing.Color.Silver;
            this.txt_BuscadorRVOE.Location = new System.Drawing.Point(6, 22);
            this.txt_BuscadorRVOE.Name = "txt_BuscadorRVOE";
            this.txt_BuscadorRVOE.Size = new System.Drawing.Size(373, 22);
            this.txt_BuscadorRVOE.TabIndex = 80;
            this.txt_BuscadorRVOE.Text = "Buscador...";
            this.txt_BuscadorRVOE.Click += new System.EventHandler(this.textBox1_Click);
            this.txt_BuscadorRVOE.TextChanged += new System.EventHandler(this.txt_BuscadorRVOE_TextChanged);
            this.txt_BuscadorRVOE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscadorRVOE_KeyPress);
            this.txt_BuscadorRVOE.Leave += new System.EventHandler(this.txt_BuscadorRVOE_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 931);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LV_Roles);
            this.groupBox3.Controls.Add(this.btnGuardarRoles);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(362, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 438);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignación de Roles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.LV_Campus);
            this.groupBox2.Controls.Add(this.LV_CampusEspecificos);
            this.groupBox2.Controls.Add(this.btnGuardarCampus);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(362, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 428);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de Campus ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCerrar);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1102, 32);
            this.panel4.TabIndex = 60;
            // 
            // lblCerrar
            // 
            this.lblCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Image = ((System.Drawing.Image)(resources.GetObject("lblCerrar.Image")));
            this.lblCerrar.Location = new System.Drawing.Point(1074, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(25, 32);
            this.lblCerrar.TabIndex = 75;
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1468, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 32);
            this.label1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1102, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Asignación de Campus y Roles a Reportes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // FrmRPT_AsignacionCampusReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 976);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_AsignacionCampusReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAniadirEspecifiacionesReporte";
            this.Load += new System.EventHandler(this.FrmRPT_AsignacionCampusReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reportes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LV_Campus;
        private System.Windows.Forms.ListView LV_CampusEspecificos;
        private System.Windows.Forms.ListView LV_RVOE;
        private System.Windows.Forms.ListView LV_Roles;
        private System.Windows.Forms.ColumnHeader ID_Rol;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.ColumnHeader ID_Campus;
        private System.Windows.Forms.ColumnHeader Campus;
        private System.Windows.Forms.Button btnGuardarCampus;
        private System.Windows.Forms.Button btnGuardarRoles;
        private System.Windows.Forms.ColumnHeader Campus_ID;
        private System.Windows.Forms.ColumnHeader NombreCampus;
        private System.Windows.Forms.Button btnGuardarRVOE;
        private System.Windows.Forms.ColumnHeader ID_RVOE;
        private System.Windows.Forms.ColumnHeader RVOE;
        private System.Windows.Forms.Button btnUsuariosReportesw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_Reportes;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.TextBox txt_BuscadorRVOE;
        private System.Windows.Forms.Button button2;
    }
}