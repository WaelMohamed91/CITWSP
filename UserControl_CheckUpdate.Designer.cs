namespace CITWSP
{
    partial class UserControl_CheckUpdate
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
            this.comb_IDcrimeOfc = new System.Windows.Forms.ComboBox();
            this.lbl_crime = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel_suspect = new System.Windows.Forms.Panel();
            this.btn_savesuspect = new System.Windows.Forms.Button();
            this.checkedList_suspect = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_suspect.SuspendLayout();
            this.SuspendLayout();
            // 
            // comb_IDcrimeOfc
            // 
            this.comb_IDcrimeOfc.FormattingEnabled = true;
            this.comb_IDcrimeOfc.Location = new System.Drawing.Point(247, 66);
            this.comb_IDcrimeOfc.Name = "comb_IDcrimeOfc";
            this.comb_IDcrimeOfc.Size = new System.Drawing.Size(121, 21);
            this.comb_IDcrimeOfc.TabIndex = 0;
            this.comb_IDcrimeOfc.SelectedIndexChanged += new System.EventHandler(this.comb_IDcrimeOfc_SelectedIndexChanged);
            // 
            // lbl_crime
            // 
            this.lbl_crime.AutoSize = true;
            this.lbl_crime.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_crime.Location = new System.Drawing.Point(121, 59);
            this.lbl_crime.Name = "lbl_crime";
            this.lbl_crime.Size = new System.Drawing.Size(120, 21);
            this.lbl_crime.TabIndex = 1;
            this.lbl_crime.Text = "Your Crime ID";
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.DimGray;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_select.Location = new System.Drawing.Point(438, 60);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(93, 31);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select ID";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel_suspect
            // 
            this.panel_suspect.BackColor = System.Drawing.Color.Transparent;
            this.panel_suspect.Controls.Add(this.label3);
            this.panel_suspect.Controls.Add(this.label2);
            this.panel_suspect.Controls.Add(this.btn_savesuspect);
            this.panel_suspect.Controls.Add(this.checkedList_suspect);
            this.panel_suspect.Controls.Add(this.label1);
            this.panel_suspect.Location = new System.Drawing.Point(107, 97);
            this.panel_suspect.Name = "panel_suspect";
            this.panel_suspect.Size = new System.Drawing.Size(478, 345);
            this.panel_suspect.TabIndex = 3;
            this.panel_suspect.Visible = false;
            // 
            // btn_savesuspect
            // 
            this.btn_savesuspect.BackColor = System.Drawing.Color.DimGray;
            this.btn_savesuspect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_savesuspect.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savesuspect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_savesuspect.Location = new System.Drawing.Point(3, 162);
            this.btn_savesuspect.Name = "btn_savesuspect";
            this.btn_savesuspect.Size = new System.Drawing.Size(173, 47);
            this.btn_savesuspect.TabIndex = 3;
            this.btn_savesuspect.Text = "Suspect";
            this.btn_savesuspect.UseVisualStyleBackColor = false;
            this.btn_savesuspect.Click += new System.EventHandler(this.btn_savesuspect_Click);
            // 
            // checkedList_suspect
            // 
            this.checkedList_suspect.FormattingEnabled = true;
            this.checkedList_suspect.Location = new System.Drawing.Point(193, 43);
            this.checkedList_suspect.Name = "checkedList_suspect";
            this.checkedList_suspect.Size = new System.Drawing.Size(256, 139);
            this.checkedList_suspect.TabIndex = 2;
            this.checkedList_suspect.SelectedIndexChanged += new System.EventHandler(this.checkedList_suspect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Suspect From This Crime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // UserControl_CheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel_suspect);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lbl_crime);
            this.Controls.Add(this.comb_IDcrimeOfc);
            this.Name = "UserControl_CheckUpdate";
            this.Size = new System.Drawing.Size(821, 508);
            this.Load += new System.EventHandler(this.UserControl_CheckUpdate_Load);
            this.panel_suspect.ResumeLayout(false);
            this.panel_suspect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comb_IDcrimeOfc;
        private System.Windows.Forms.Label lbl_crime;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel panel_suspect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedList_suspect;
        private System.Windows.Forms.Button btn_savesuspect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
