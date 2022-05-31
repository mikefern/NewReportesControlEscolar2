namespace ProyectoLoboSostenido
{
    partial class FrmFRVisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFRVisor));
            this.FRpvwControl = new FastReport.Preview.PreviewControl();
            this.SuspendLayout();
            // 
            // FRpvwControl
            // 
            this.FRpvwControl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FRpvwControl.Buttons = ((FastReport.PreviewButtons)(((((((((FastReport.PreviewButtons.Print | FastReport.PreviewButtons.Save) 
            | FastReport.PreviewButtons.Find) 
            | FastReport.PreviewButtons.Zoom) 
            | FastReport.PreviewButtons.Outline) 
            | FastReport.PreviewButtons.PageSetup) 
            | FastReport.PreviewButtons.Watermark) 
            | FastReport.PreviewButtons.Navigator) 
            | FastReport.PreviewButtons.Close)));
            this.FRpvwControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FRpvwControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FRpvwControl.Location = new System.Drawing.Point(0, 0);
            this.FRpvwControl.Name = "FRpvwControl";
            this.FRpvwControl.PageOffset = new System.Drawing.Point(10, 10);
            this.FRpvwControl.Size = new System.Drawing.Size(757, 444);
            this.FRpvwControl.TabIndex = 0;
            this.FRpvwControl.UIStyle = FastReport.Utils.UIStyle.Office2013;
            // 
            // FrmFRVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 444);
            this.Controls.Add(this.FRpvwControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFRVisor";
            this.Text = "Visor de Reportes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFRVisor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Preview.PreviewControl FRpvwControl;


    }
}