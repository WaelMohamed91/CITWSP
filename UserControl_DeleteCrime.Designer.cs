namespace CITWSP
{
    partial class UserControl_DeleteCrime
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
            this.lbl_Del = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Remove_Crim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Del
            // 
            this.lbl_Del.AutoSize = true;
            this.lbl_Del.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Del.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Del.ForeColor = System.Drawing.Color.White;
            this.lbl_Del.Location = new System.Drawing.Point(30, 151);
            this.lbl_Del.Name = "lbl_Del";
            this.lbl_Del.Size = new System.Drawing.Size(180, 27);
            this.lbl_Del.TabIndex = 0;
            this.lbl_Del.Text = "Enter Crime ID :-";
            this.lbl_Del.Click += new System.EventHandler(this.lbl_Del_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Remove_Crim
            // 
            this.btn_Remove_Crim.BackColor = System.Drawing.Color.DimGray;
            this.btn_Remove_Crim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove_Crim.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove_Crim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Remove_Crim.Location = new System.Drawing.Point(151, 231);
            this.btn_Remove_Crim.Name = "btn_Remove_Crim";
            this.btn_Remove_Crim.Size = new System.Drawing.Size(146, 49);
            this.btn_Remove_Crim.TabIndex = 3;
            this.btn_Remove_Crim.Text = "Remove";
            this.btn_Remove_Crim.UseVisualStyleBackColor = false;
            this.btn_Remove_Crim.Click += new System.EventHandler(this.btn_Remove_Crim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CITWSP.Properties.Resources.arrows_box_business_5331892;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(381, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 613);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CITWSP.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(103, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 49);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserControl_DeleteCrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Remove_Crim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Del);
            this.Name = "UserControl_DeleteCrime";
            this.Size = new System.Drawing.Size(841, 570);
            this.Load += new System.EventHandler(this.UserControl_DeleteCrime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Del;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Remove_Crim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
