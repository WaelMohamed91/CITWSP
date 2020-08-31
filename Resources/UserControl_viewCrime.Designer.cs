namespace CITWSP.Resources
{
    partial class UserControl_viewCrime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridView_viewCrime = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_viewCrime)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_viewCrime
            // 
            this.GridView_viewCrime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_viewCrime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_viewCrime.Location = new System.Drawing.Point(0, 0);
            this.GridView_viewCrime.Name = "GridView_viewCrime";
            this.GridView_viewCrime.Size = new System.Drawing.Size(643, 454);
            this.GridView_viewCrime.TabIndex = 0;
            // 
            // UserControl_viewCrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridView_viewCrime);
            this.Name = "UserControl_viewCrime";
            this.Size = new System.Drawing.Size(643, 454);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_viewCrime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_viewCrime;
    }
}
