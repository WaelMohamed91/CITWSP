namespace CITWSP
{
    partial class UserControl_Officers
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
            this.lbl_officID = new System.Windows.Forms.Label();
            this.lbl_offic_name = new System.Windows.Forms.Label();
            this.txt_offic_ID = new System.Windows.Forms.TextBox();
            this.txt_offc_name = new System.Windows.Forms.TextBox();
            this.btn_saveOffice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_officID
            // 
            this.lbl_officID.AutoSize = true;
            this.lbl_officID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_officID.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_officID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_officID.Location = new System.Drawing.Point(292, 139);
            this.lbl_officID.Name = "lbl_officID";
            this.lbl_officID.Size = new System.Drawing.Size(97, 24);
            this.lbl_officID.TabIndex = 0;
            this.lbl_officID.Text = "Officer ID";
            // 
            // lbl_offic_name
            // 
            this.lbl_offic_name.AutoSize = true;
            this.lbl_offic_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_offic_name.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offic_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_offic_name.Location = new System.Drawing.Point(292, 179);
            this.lbl_offic_name.Name = "lbl_offic_name";
            this.lbl_offic_name.Size = new System.Drawing.Size(129, 24);
            this.lbl_offic_name.TabIndex = 1;
            this.lbl_offic_name.Text = "Officer Name";
            // 
            // txt_offic_ID
            // 
            this.txt_offic_ID.Location = new System.Drawing.Point(428, 139);
            this.txt_offic_ID.Name = "txt_offic_ID";
            this.txt_offic_ID.Size = new System.Drawing.Size(117, 20);
            this.txt_offic_ID.TabIndex = 2;
            // 
            // txt_offc_name
            // 
            this.txt_offc_name.Location = new System.Drawing.Point(427, 183);
            this.txt_offc_name.Name = "txt_offc_name";
            this.txt_offc_name.Size = new System.Drawing.Size(118, 20);
            this.txt_offc_name.TabIndex = 3;
            // 
            // btn_saveOffice
            // 
            this.btn_saveOffice.BackColor = System.Drawing.Color.DimGray;
            this.btn_saveOffice.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveOffice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_saveOffice.Location = new System.Drawing.Point(346, 256);
            this.btn_saveOffice.Name = "btn_saveOffice";
            this.btn_saveOffice.Size = new System.Drawing.Size(177, 48);
            this.btn_saveOffice.TabIndex = 4;
            this.btn_saveOffice.Text = "Add Officer";
            this.btn_saveOffice.UseVisualStyleBackColor = false;
            this.btn_saveOffice.Click += new System.EventHandler(this.btn_saveOffice_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CITWSP.Properties.Resources.police_line;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(296, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 48);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserControl_Officers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CITWSP.Properties.Resources.collin_armstrong_195852_unsplash2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_saveOffice);
            this.Controls.Add(this.txt_offc_name);
            this.Controls.Add(this.txt_offic_ID);
            this.Controls.Add(this.lbl_offic_name);
            this.Controls.Add(this.lbl_officID);
            this.Name = "UserControl_Officers";
            this.Size = new System.Drawing.Size(719, 541);
            this.Load += new System.EventHandler(this.UserControl_Officers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_officID;
        private System.Windows.Forms.Label lbl_offic_name;
        private System.Windows.Forms.TextBox txt_offic_ID;
        private System.Windows.Forms.TextBox txt_offc_name;
        private System.Windows.Forms.Button btn_saveOffice;
        private System.Windows.Forms.Button button1;
    }
}
