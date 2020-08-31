namespace CITWSP
{
    partial class UserControl_Add_Admin
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
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.txt_Adminname = new System.Windows.Forms.TextBox();
            this.btn_AddAdm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminID.Location = new System.Drawing.Point(282, 143);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.Size = new System.Drawing.Size(116, 26);
            this.txt_AdminID.TabIndex = 0;
            // 
            // txt_Adminname
            // 
            this.txt_Adminname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Adminname.Location = new System.Drawing.Point(282, 190);
            this.txt_Adminname.Name = "txt_Adminname";
            this.txt_Adminname.Size = new System.Drawing.Size(116, 26);
            this.txt_Adminname.TabIndex = 1;
            this.txt_Adminname.TextChanged += new System.EventHandler(this.txt_Adminname_TextChanged);
            // 
            // btn_AddAdm
            // 
            this.btn_AddAdm.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAdm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddAdm.Location = new System.Drawing.Point(219, 233);
            this.btn_AddAdm.Name = "btn_AddAdm";
            this.btn_AddAdm.Size = new System.Drawing.Size(138, 48);
            this.btn_AddAdm.TabIndex = 3;
            this.btn_AddAdm.Text = "Add";
            this.btn_AddAdm.UseVisualStyleBackColor = false;
            this.btn_AddAdm.Click += new System.EventHandler(this.btn_AddAdm_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(141, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(128, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CITWSP.Properties.Resources.add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(166, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 48);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserControl_Add_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CITWSP.Properties.Resources.garrhet_sampson_178990_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddAdm);
            this.Controls.Add(this.txt_Adminname);
            this.Controls.Add(this.txt_AdminID);
            this.Name = "UserControl_Add_Admin";
            this.Size = new System.Drawing.Size(641, 429);
            this.Load += new System.EventHandler(this.UserControl_Add_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.TextBox txt_Adminname;
        private System.Windows.Forms.Button btn_AddAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
