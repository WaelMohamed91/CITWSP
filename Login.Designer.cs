namespace CITWSP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_AsOfficer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_AsAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_loginn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(154, 36);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(126, 20);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(155, 81);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(126, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id.Location = new System.Drawing.Point(66, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 27);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.Location = new System.Drawing.Point(66, 74);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 27);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name :";
            // 
            // btn_AsOfficer
            // 
            this.btn_AsOfficer.BackColor = System.Drawing.Color.DimGray;
            this.btn_AsOfficer.color = System.Drawing.Color.DimGray;
            this.btn_AsOfficer.colorActive = System.Drawing.Color.Gray;
            this.btn_AsOfficer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AsOfficer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_AsOfficer.ForeColor = System.Drawing.Color.White;
            this.btn_AsOfficer.Image = global::CITWSP.Properties.Resources.police;
            this.btn_AsOfficer.ImagePosition = 20;
            this.btn_AsOfficer.ImageZoom = 50;
            this.btn_AsOfficer.LabelPosition = 41;
            this.btn_AsOfficer.LabelText = "Officer";
            this.btn_AsOfficer.Location = new System.Drawing.Point(15, 228);
            this.btn_AsOfficer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AsOfficer.Name = "btn_AsOfficer";
            this.btn_AsOfficer.Size = new System.Drawing.Size(128, 129);
            this.btn_AsOfficer.TabIndex = 1;
            this.btn_AsOfficer.Click += new System.EventHandler(this.btn_AsOfficer_Click);
            // 
            // btn_AsAdmin
            // 
            this.btn_AsAdmin.BackColor = System.Drawing.Color.DimGray;
            this.btn_AsAdmin.color = System.Drawing.Color.DimGray;
            this.btn_AsAdmin.colorActive = System.Drawing.Color.Gray;
            this.btn_AsAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AsAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_AsAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_AsAdmin.Image = global::CITWSP.Properties.Resources.icons8_user_502;
            this.btn_AsAdmin.ImagePosition = 20;
            this.btn_AsAdmin.ImageZoom = 50;
            this.btn_AsAdmin.LabelPosition = 41;
            this.btn_AsAdmin.LabelText = "Admin";
            this.btn_AsAdmin.Location = new System.Drawing.Point(15, 99);
            this.btn_AsAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AsAdmin.Name = "btn_AsAdmin";
            this.btn_AsAdmin.Size = new System.Drawing.Size(128, 129);
            this.btn_AsAdmin.TabIndex = 0;
            this.btn_AsAdmin.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btn_loginn
            // 
            this.btn_loginn.Activecolor = System.Drawing.Color.DimGray;
            this.btn_loginn.BackColor = System.Drawing.Color.DimGray;
            this.btn_loginn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loginn.BorderRadius = 0;
            this.btn_loginn.ButtonText = "Log IN";
            this.btn_loginn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginn.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_loginn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_loginn.Iconimage")));
            this.btn_loginn.Iconimage_right = null;
            this.btn_loginn.Iconimage_right_Selected = null;
            this.btn_loginn.Iconimage_Selected = null;
            this.btn_loginn.IconZoom = 90D;
            this.btn_loginn.IsTab = false;
            this.btn_loginn.Location = new System.Drawing.Point(58, 153);
            this.btn_loginn.Name = "btn_loginn";
            this.btn_loginn.Normalcolor = System.Drawing.Color.DimGray;
            this.btn_loginn.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_loginn.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_loginn.selected = false;
            this.btn_loginn.Size = new System.Drawing.Size(241, 48);
            this.btn_loginn.TabIndex = 9;
            this.btn_loginn.Textcolor = System.Drawing.Color.White;
            this.btn_loginn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginn.Click += new System.EventHandler(this.btn_loginn_Click);
            // 
            // panel_log
            // 
            this.panel_log.BackColor = System.Drawing.Color.Transparent;
            this.panel_log.Controls.Add(this.btn_loginn);
            this.panel_log.Controls.Add(this.lbl_name);
            this.panel_log.Controls.Add(this.lbl_id);
            this.panel_log.Controls.Add(this.txt_Name);
            this.panel_log.Controls.Add(this.txt_ID);
            this.panel_log.Location = new System.Drawing.Point(223, 99);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(398, 230);
            this.panel_log.TabIndex = 10;
            this.panel_log.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 47);
            this.label2.TabIndex = 11;
            this.label2.Text = "Criminal Investigation";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CITWSP.Properties.Resources.beach_fog_men_384422;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AsOfficer);
            this.Controls.Add(this.btn_AsAdmin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btn_AsAdmin;
        private Bunifu.Framework.UI.BunifuTileButton btn_AsOfficer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private Bunifu.Framework.UI.BunifuFlatButton btn_loginn;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_ID;
    }
}

