
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
            this.DGV_parametros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_parametros
            // 
            this.DGV_parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_parametros.Location = new System.Drawing.Point(177, 23);
            this.DGV_parametros.Name = "DGV_parametros";
            this.DGV_parametros.Size = new System.Drawing.Size(388, 907);
            this.DGV_parametros.TabIndex = 0;
            this.DGV_parametros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_parametros_CellEndEdit);
            this.DGV_parametros.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_parametros_EditingControlShowing);
            this.DGV_parametros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_parametros_RowsAdded_1);
            this.DGV_parametros.SelectionChanged += new System.EventHandler(this.DGV_parametros_SelectionChanged);
            this.DGV_parametros.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGV_parametros_UserDeletingRow);
            this.DGV_parametros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_parametros_KeyDown);
            this.DGV_parametros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_parametros_KeyPress);
            this.DGV_parametros.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DGV_parametros_PreviewKeyDown);
            // 
            // FrmAdministrarParametrosRCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 983);
            this.Controls.Add(this.DGV_parametros);
            this.Name = "FrmAdministrarParametrosRCE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrarParametrosRCE";
            this.Load += new System.EventHandler(this.FrmAdministrarParametrosRCE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_parametros;
    }
}