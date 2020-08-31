namespace CITWSP
{
    partial class UserControl_CrimeUpdate
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
            this.lbl_crime_ID = new System.Windows.Forms.Label();
            this.txt_C_ID = new System.Windows.Forms.TextBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.btn_Save_Update = new System.Windows.Forms.Button();
            this.btn_Update_img = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.btn_ID_search = new System.Windows.Forms.Button();
            this.lbl_crime_status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_C_Statue = new System.Windows.Forms.ComboBox();
            this.panelviibles = new System.Windows.Forms.Panel();
            this.panelviibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_crime_ID
            // 
            this.lbl_crime_ID.AutoSize = true;
            this.lbl_crime_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_crime_ID.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crime_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_crime_ID.Location = new System.Drawing.Point(171, 41);
            this.lbl_crime_ID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_crime_ID.Name = "lbl_crime_ID";
            this.lbl_crime_ID.Size = new System.Drawing.Size(145, 24);
            this.lbl_crime_ID.TabIndex = 0;
            this.lbl_crime_ID.Text = "Enter Crime ID";
            // 
            // txt_C_ID
            // 
            this.txt_C_ID.Location = new System.Drawing.Point(363, 38);
            this.txt_C_ID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_C_ID.Name = "txt_C_ID";
            this.txt_C_ID.Size = new System.Drawing.Size(219, 31);
            this.txt_C_ID.TabIndex = 5;
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(219, 73);
            this.txt_Item.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(219, 31);
            this.txt_Item.TabIndex = 20;
            this.txt_Item.TextChanged += new System.EventHandler(this.txt_Item_TextChanged);
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Image.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Image.Location = new System.Drawing.Point(43, 139);
            this.lbl_Image.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(101, 21);
            this.lbl_Image.TabIndex = 19;
            this.lbl_Image.Text = "More Image";
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Item.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Item.Location = new System.Drawing.Point(43, 73);
            this.lbl_Item.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(111, 24);
            this.lbl_Item.TabIndex = 18;
            this.lbl_Item.Text = "Item Found";
            // 
            // btn_Save_Update
            // 
            this.btn_Save_Update.BackColor = System.Drawing.Color.DimGray;
            this.btn_Save_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save_Update.Location = new System.Drawing.Point(200, 223);
            this.btn_Save_Update.Name = "btn_Save_Update";
            this.btn_Save_Update.Size = new System.Drawing.Size(188, 48);
            this.btn_Save_Update.TabIndex = 23;
            this.btn_Save_Update.Text = "Save Update";
            this.btn_Save_Update.UseVisualStyleBackColor = false;
            this.btn_Save_Update.Click += new System.EventHandler(this.btn_Save_Update_Click);
            // 
            // btn_Update_img
            // 
            this.btn_Update_img.BackColor = System.Drawing.Color.DimGray;
            this.btn_Update_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update_img.Location = new System.Drawing.Point(219, 139);
            this.btn_Update_img.Name = "btn_Update_img";
            this.btn_Update_img.Size = new System.Drawing.Size(193, 42);
            this.btn_Update_img.TabIndex = 27;
            this.btn_Update_img.Text = "Attach Image";
            this.btn_Update_img.UseVisualStyleBackColor = false;
            this.btn_Update_img.Click += new System.EventHandler(this.btn_Update_img_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CITWSP.Properties.Resources.download_button__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(152, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 48);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.Transparent;
            this.btn_img.BackgroundImage = global::CITWSP.Properties.Resources.attachment;
            this.btn_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_img.Enabled = false;
            this.btn_img.Location = new System.Drawing.Point(407, 139);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(52, 42);
            this.btn_img.TabIndex = 26;
            this.btn_img.UseVisualStyleBackColor = false;
            // 
            // btn_ID_search
            // 
            this.btn_ID_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_ID_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ID_search.Image = global::CITWSP.Properties.Resources.search;
            this.btn_ID_search.Location = new System.Drawing.Point(622, 38);
            this.btn_ID_search.Name = "btn_ID_search";
            this.btn_ID_search.Size = new System.Drawing.Size(49, 31);
            this.btn_ID_search.TabIndex = 25;
            this.btn_ID_search.UseVisualStyleBackColor = false;
            this.btn_ID_search.Click += new System.EventHandler(this.btn_ID_search_Click);
            // 
            // lbl_crime_status
            // 
            this.lbl_crime_status.AutoSize = true;
            this.lbl_crime_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_crime_status.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crime_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_crime_status.Location = new System.Drawing.Point(27, 21);
            this.lbl_crime_status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_crime_status.Name = "lbl_crime_status";
            this.lbl_crime_status.Size = new System.Drawing.Size(127, 24);
            this.lbl_crime_status.TabIndex = 17;
            this.lbl_crime_status.Text = "Crime Status";
            // 
            // cmb_C_Statue
            // 
            this.cmb_C_Statue.FormattingEnabled = true;
            this.cmb_C_Statue.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cmb_C_Statue.Location = new System.Drawing.Point(219, 13);
            this.cmb_C_Statue.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_C_Statue.Name = "cmb_C_Statue";
            this.cmb_C_Statue.Size = new System.Drawing.Size(219, 32);
            this.cmb_C_Statue.TabIndex = 21;
            this.cmb_C_Statue.SelectedIndexChanged += new System.EventHandler(this.cmb_C_Statue_SelectedIndexChanged);
            // 
            // panelviibles
            // 
            this.panelviibles.BackColor = System.Drawing.Color.Transparent;
            this.panelviibles.Controls.Add(this.button1);
            this.panelviibles.Controls.Add(this.btn_Update_img);
            this.panelviibles.Controls.Add(this.btn_img);
            this.panelviibles.Controls.Add(this.btn_Save_Update);
            this.panelviibles.Controls.Add(this.cmb_C_Statue);
            this.panelviibles.Controls.Add(this.txt_Item);
            this.panelviibles.Controls.Add(this.lbl_Image);
            this.panelviibles.Controls.Add(this.lbl_Item);
            this.panelviibles.Controls.Add(this.lbl_crime_status);
            this.panelviibles.Location = new System.Drawing.Point(144, 76);
            this.panelviibles.Name = "panelviibles";
            this.panelviibles.Size = new System.Drawing.Size(511, 285);
            this.panelviibles.TabIndex = 29;
            this.panelviibles.Visible = false;
            // 
            // UserControl_CrimeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::CITWSP.Properties.Resources._301441_pijani_i_vooruzheni_mazhi_upadnale_vo_azilantski_dom1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelviibles);
            this.Controls.Add(this.btn_ID_search);
            this.Controls.Add(this.txt_C_ID);
            this.Controls.Add(this.lbl_crime_ID);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_CrimeUpdate";
            this.Size = new System.Drawing.Size(888, 573);
            this.Load += new System.EventHandler(this.UserControl_CrimeUpdate_Load);
            this.panelviibles.ResumeLayout(false);
            this.panelviibles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion

        private System.Windows.Forms.Label lbl_crime_ID;
        private System.Windows.Forms.TextBox txt_C_ID;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.Button btn_Save_Update;
        private System.Windows.Forms.Button btn_ID_search;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btn_Update_img;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_crime_status;
        private System.Windows.Forms.ComboBox cmb_C_Statue;
        private System.Windows.Forms.Panel panelviibles;
    }
}
