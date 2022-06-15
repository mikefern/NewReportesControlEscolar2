
namespace NewReportesControlEscolar
{
    partial class FrmAdministrarParametrosRCE
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
            this.components = new System.ComponentModel.Container();
            this.DGV_parametros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID_Parametro = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_parametros
            // 
            this.DGV_parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_parametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_parametros.Location = new System.Drawing.Point(56, 64);
            this.DGV_parametros.Name = "DGV_parametros";
            this.DGV_parametros.Size = new System.Drawing.Size(388, 551);
            this.DGV_parametros.TabIndex = 0;
            this.DGV_parametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_parametros_CellContentClick);
            this.DGV_parametros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_parametros_CellEndEdit);
            this.DGV_parametros.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_parametros_CellMouseUp);
            this.DGV_parametros.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_parametros_EditingControlShowing);
            this.DGV_parametros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_parametros_RowsAdded_1);
            this.DGV_parametros.SelectionChanged += new System.EventHandler(this.DGV_parametros_SelectionChanged);
            this.DGV_parametros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_parametros_KeyDown);
            this.DGV_parametros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_parametros_KeyPress);
            this.DGV_parametros.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DGV_parametros_PreviewKeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // txtID_Parametro
            // 
            this.txtID_Parametro.Location = new System.Drawing.Point(643, 331);
            this.txtID_Parametro.Name = "txtID_Parametro";
            this.txtID_Parametro.Size = new System.Drawing.Size(48, 38);
            this.txtID_Parametro.TabIndex = 4;
            this.txtID_Parametro.Text = "";
            this.txtID_Parametro.Visible = false;
            // 
            // FrmAdministrarParametrosRCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 734);
            this.Controls.Add(this.txtID_Parametro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_parametros);
            this.Name = "FrmAdministrarParametrosRCE";
            this.Text = "FrmAdministrarParametrosRCE";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_parametros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtID_Parametro;
    }
}