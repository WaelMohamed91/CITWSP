namespace CITWSP
{
    partial class UserControl_CrimeType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_CrimeType));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_CrimeID = new System.Windows.Forms.TextBox();
            this.txt_CrimeName = new System.Windows.Forms.TextBox();
            this.btn_Check = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_AddCrime = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Check)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Location = new System.Drawing.Point(145, 136);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(111, 24);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Crime Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ID.Location = new System.Drawing.Point(168, 100);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(88, 24);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Crime ID ";
            // 
            // txt_CrimeID
            // 
            this.txt_CrimeID.Location = new System.Drawing.Point(285, 100);
            this.txt_CrimeID.Name = "txt_CrimeID";
            this.txt_CrimeID.Size = new System.Drawing.Size(119, 20);
            this.txt_CrimeID.TabIndex = 2;
            this.txt_CrimeID.TextChanged += new System.EventHandler(this.txt_CrimeID_TextChanged);
            // 
            // txt_CrimeName
            // 
            this.txt_CrimeName.Enabled = false;
            this.txt_CrimeName.Location = new System.Drawing.Point(285, 140);
            this.txt_CrimeName.Name = "txt_CrimeName";
            this.txt_CrimeName.Size = new System.Drawing.Size(119, 20);
            this.txt_CrimeName.TabIndex = 3;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Image = global::CITWSP.Properties.Resources.search__1_;
            this.btn_Check.ImageActive = global::CITWSP.Properties.Resources.loupe1;
            this.btn_Check.Location = new System.Drawing.Point(397, 100);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(65, 24);
            this.btn_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Check.TabIndex = 8;
            this.btn_Check.TabStop = false;
            this.btn_Check.Zoom = 10;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click_2);
            // 
            // btn_AddCrime
            // 
            this.btn_AddCrime.Activecolor = System.Drawing.Color.DimGray;
            this.btn_AddCrime.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddCrime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddCrime.BorderRadius = 0;
            this.btn_AddCrime.ButtonText = "    Add";
            this.btn_AddCrime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCrime.Enabled = false;
            this.btn_AddCrime.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AddCrime.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AddCrime.Iconimage")));
            this.btn_AddCrime.Iconimage_right = null;
            this.btn_AddCrime.Iconimage_right_Selected = null;
            this.btn_AddCrime.Iconimage_Selected = null;
            this.btn_AddCrime.IconZoom = 90D;
            this.btn_AddCrime.IsTab = false;
            this.btn_AddCrime.Location = new System.Drawing.Point(270, 229);
            this.btn_AddCrime.Name = "btn_AddCrime";
            this.btn_AddCrime.Normalcolor = System.Drawing.Color.DimGray;
            this.btn_AddCrime.OnHovercolor = System.Drawing.Color.DimGray;
            this.btn_AddCrime.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AddCrime.selected = false;
            this.btn_AddCrime.Size = new System.Drawing.Size(192, 48);
            this.btn_AddCrime.TabIndex = 7;
            this.btn_AddCrime.Textcolor = System.Drawing.Color.White;
            this.btn_AddCrime.TextFont = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCrime.Click += new System.EventHandler(this.btn_AddCrime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // UserControl_CrimeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_AddCrime);
            this.Controls.Add(this.txt_CrimeName);
            this.Controls.Add(this.txt_CrimeID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Name);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "UserControl_CrimeType";
            this.Size = new System.Drawing.Size(622, 465);
            this.Load += new System.EventHandler(this.UserControl_CrimeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AddCrime;
        private Bunifu.Framework.UI.BunifuImageButton btn_Check;
        public System.Windows.Forms.TextBox txt_CrimeName;
        public System.Windows.Forms.TextBox txt_CrimeID;
        private System.Windows.Forms.Label label1;
    }
}
