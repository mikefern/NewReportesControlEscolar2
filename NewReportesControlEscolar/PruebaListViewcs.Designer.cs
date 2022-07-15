
namespace NewReportesControlEscolar
{
    partial class PruebaListViewcs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvRVOE = new System.Windows.Forms.ListView();
            this.ID_RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RVOE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvRVOE
            // 
            this.lvRVOE.CheckBoxes = true;
            this.lvRVOE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_RVOE,
            this.RVOE});
            this.lvRVOE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lvRVOE.HideSelection = false;
            this.lvRVOE.Location = new System.Drawing.Point(12, 65);
            this.lvRVOE.Name = "lvRVOE";
            this.lvRVOE.Size = new System.Drawing.Size(391, 626);
            this.lvRVOE.TabIndex = 4;
            this.lvRVOE.UseCompatibleStateImageBehavior = false;
            this.lvRVOE.View = System.Windows.Forms.View.Details;
            this.lvRVOE.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvRVOE_ItemChecked);
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
            // PruebaListViewcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 734);
            this.Controls.Add(this.lvRVOE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "PruebaListViewcs";
            this.Text = "PruebaListViewcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvRVOE;
        private System.Windows.Forms.ColumnHeader ID_RVOE;
        private System.Windows.Forms.ColumnHeader RVOE;
    }
}