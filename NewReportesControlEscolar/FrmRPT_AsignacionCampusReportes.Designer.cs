
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_AsignacionCampusReportes));
            this.lvCampus = new System.Windows.Forms.ListView();
            this.ID_Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCampusEspecificos = new System.Windows.Forms.ListView();
            this.Campus_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCampus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRVOE = new System.Windows.Forms.ListView();
            this.ID_RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoles = new System.Windows.Forms.ListView();
            this.ID_Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarCampus = new System.Windows.Forms.Button();
            this.btnGuardarRoles = new System.Windows.Forms.Button();
            this.btnGuardarRVOE = new System.Windows.Forms.Button();
            this.btnUsuariosReportesw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGV_Reportes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // lvCampus
            // 
            this.lvCampus.CheckBoxes = true;
            this.lvCampus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Campus,
            this.Campus});
            this.lvCampus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvCampus.HideSelection = false;
            this.lvCampus.Location = new System.Drawing.Point(6, 24);
            this.lvCampus.Name = "lvCampus";
            this.lvCampus.Size = new System.Drawing.Size(294, 364);
            this.lvCampus.TabIndex = 1;
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
            this.Campus.Width = 196;
            // 
            // lvCampusEspecificos
            // 
            this.lvCampusEspecificos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campus_ID,
            this.NombreCampus});
            this.lvCampusEspecificos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvCampusEspecificos.HideSelection = false;
            this.lvCampusEspecificos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvCampusEspecificos.Location = new System.Drawing.Point(318, 22);
            this.lvCampusEspecificos.Name = "lvCampusEspecificos";
            this.lvCampusEspecificos.Size = new System.Drawing.Size(382, 366);
            this.lvCampusEspecificos.TabIndex = 2;
            this.lvCampusEspecificos.UseCompatibleStateImageBehavior = false;
            this.lvCampusEspecificos.View = System.Windows.Forms.View.Details;
            this.lvCampusEspecificos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCampusEspecificos_ItemSelectionChanged);
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
            // lvRVOE
            // 
            this.lvRVOE.CheckBoxes = true;
            this.lvRVOE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_RVOE,
            this.RVOE});
            this.lvRVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvRVOE.HideSelection = false;
            this.lvRVOE.Location = new System.Drawing.Point(6, 22);
            this.lvRVOE.Name = "lvRVOE";
            this.lvRVOE.Size = new System.Drawing.Size(382, 381);
            this.lvRVOE.TabIndex = 3;
            this.lvRVOE.UseCompatibleStateImageBehavior = false;
            this.lvRVOE.View = System.Windows.Forms.View.Details;
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
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Rol,
            this.Rol});
            this.lvRoles.Enabled = false;
            this.lvRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(6, 22);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(294, 378);
            this.lvRoles.TabIndex = 4;
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
            this.btnGuardarRVOE.Location = new System.Drawing.Point(37, 408);
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
            this.btnUsuariosReportesw.Location = new System.Drawing.Point(69, 38);
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
            this.panel1.Controls.Add(this.textBox1);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 912);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 85;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DGV_Reportes
            // 
            this.DGV_Reportes.AllowUserToAddRows = false;
            this.DGV_Reportes.AllowUserToDeleteRows = false;
            this.DGV_Reportes.AllowUserToResizeRows = false;
            this.DGV_Reportes.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Reportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Reportes.Location = new System.Drawing.Point(42, 146);
            this.DGV_Reportes.MultiSelect = false;
            this.DGV_Reportes.Name = "DGV_Reportes";
            this.DGV_Reportes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Reportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Reportes.RowHeadersVisible = false;
            this.DGV_Reportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_Reportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Reportes.Size = new System.Drawing.Size(286, 493);
            this.DGV_Reportes.TabIndex = 84;
            this.DGV_Reportes.SelectionChanged += new System.EventHandler(this.DGV_Reportes_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.Location = new System.Drawing.Point(114, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Reportes Existentes ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(33, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 520);
            this.button1.TabIndex = 82;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(33, 818);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 36);
            this.label7.TabIndex = 81;
            this.label7.Text = "Paso 4. Para asignar el RVOE haga click en el ID del Campus en el segundo apartad" +
    "o y guarde.";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 773);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 36);
            this.label5.TabIndex = 80;
            this.label5.Text = "Paso 3. Asigne los roles que pueden ver el reporte  en los campus seleccionados y" +
    " guarde.";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 721);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 36);
            this.label4.TabIndex = 79;
            this.label4.Text = "Paso 2. En el apartado asiganción de campus elija  el o los Campus y guarde.";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 36);
            this.label3.TabIndex = 78;
            this.label3.Text = "Paso 1. Elija el reporte al que asignará el Campus y Rol.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvRVOE);
            this.groupBox4.Controls.Add(this.btnGuardarRVOE);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(674, 472);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 438);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asignación de RVOE según el Campus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 408);
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
            this.pictureBox3.Location = new System.Drawing.Point(33, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvRoles);
            this.groupBox3.Controls.Add(this.btnGuardarRoles);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(362, 472);
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
            this.groupBox2.Controls.Add(this.lvCampus);
            this.groupBox2.Controls.Add(this.lvCampusEspecificos);
            this.groupBox2.Controls.Add(this.btnGuardarCampus);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(362, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 428);
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
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1098, 32);
            this.panel4.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(1069, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 75;
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1587, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 58;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1098, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Asignación de Campus y Roles a Reportes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRPT_AsignacionCampusReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 912);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_AsignacionCampusReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAniadirEspecifiacionesReporte";
            this.Load += new System.EventHandler(this.FrmAniadirEspecifiacionesReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reportes)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvCampus;
        private System.Windows.Forms.ListView lvCampusEspecificos;
        private System.Windows.Forms.ListView lvRVOE;
        private System.Windows.Forms.ListView lvRoles;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_Reportes;
        private System.Windows.Forms.TextBox textBox1;
    }
}