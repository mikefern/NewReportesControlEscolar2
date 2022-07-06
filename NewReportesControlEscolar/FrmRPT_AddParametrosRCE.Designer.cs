
namespace NewReportesControlEscolar
{
    partial class FrmRPT_AddParametrosRCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPT_AddParametrosRCE));
            this.DGV_parametros = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_parametros
            // 
            this.DGV_parametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_parametros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_parametros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_parametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_parametros.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_parametros.Location = new System.Drawing.Point(5, 47);
            this.DGV_parametros.Name = "DGV_parametros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_parametros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_parametros.Size = new System.Drawing.Size(378, 837);
            this.DGV_parametros.TabIndex = 0;
            this.DGV_parametros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_parametros_CellEndEdit);
            this.DGV_parametros.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_parametros_EditingControlShowing);
            this.DGV_parametros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_parametros_RowsAdded);
            this.DGV_parametros.SelectionChanged += new System.EventHandler(this.DGV_parametros_SelectionChanged);
            this.DGV_parametros.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGV_parametros_UserDeletingRow);
            this.DGV_parametros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_parametros_KeyDown);
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(611, 32);
            this.lbltitulo.TabIndex = 62;
            this.lbltitulo.Text = "Agregar Parametros ";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitulo_MouseDown);
            // 
            // lblCerrar
            // 
            this.lblCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Image = ((System.Drawing.Image)(resources.GetObject("lblCerrar.Image")));
            this.lblCerrar.Location = new System.Drawing.Point(576, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(25, 32);
            this.lblCerrar.TabIndex = 71;
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 90);
            this.label3.TabIndex = 73;
            this.label3.Text = "1. Para insertar un nuevo parametro, haga doble click en el ultimo renglon vacío " +
    "(Columna Nombre) escriba el nombre del parametro y presione la tecla Enter.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 75);
            this.label2.TabIndex = 74;
            this.label2.Text = "2. Para modificar un parametro, haga doble click en el renglon, modifique la colu" +
    "mna que desee y presione la tecla Enter.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 83);
            this.label4.TabIndex = 75;
            this.label4.Text = "3. Para eliminar un renglon o registro, seleccione el renglón completo (presionan" +
    "do la flecha de la izq) y presione la tecla Suprimir.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmRPT_AddParametrosRCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(611, 896);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.DGV_parametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRPT_AddParametrosRCE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrarParametrosRCE";
            this.Load += new System.EventHandler(this.FrmAdministrarParametrosRCE_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAdministrarParametrosRCE_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_parametros;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}