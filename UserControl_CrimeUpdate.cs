using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace CITWSP
{
    public partial class UserControl_CrimeUpdate : UserControl
    {
        public static String Status;
        int variable_check;
        Crimes Crimes_obj;
        Image file;
        string officer_id;
        Officer officer_obj;
        bool flag = true; 
       
        public UserControl_CrimeUpdate()
        {
            InitializeComponent();
        }

        private void UserControl_CrimeUpdate_Load(object sender, EventArgs e)
        {
            Crimes_obj = new Crimes();
            Crimes_obj.Load();
            // Visible_false();
            officer_obj = new Officer();
            officer_obj.Lood_Officers();


        }



        //*****************************
        public bool save_image()
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "jpg files(*.jpg)|*.jpg";
            if (o.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(o.FileName);
                for (int i = 0; i < Crimes_obj.Crimess.Count; i++)
                {
                    if (Crimes_obj.Crimess[i].Crime_ID == txt_C_ID.Text)
                    {
                        string f = txt_C_ID.Text + "." + Crimes_obj.Crimess[i].Num_Image + ".jpg";
                        string folder = Environment.CurrentDirectory + "\\" + txt_C_ID.Text;
                        string path = System.IO.Path.Combine(folder, f);
                        file.Save(path);
                        Crimes_obj.incrementimage(txt_C_ID.Text);
                        break;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
           //

        }

        public bool Check_Status()
        {
            if (cmb_C_Statue.SelectedItem.ToString() == "Open")
            {
                for (int i = 0; i < Crimes_obj.Crimess.Count; i++)
                {
                    if (Crimes_obj.Crimess[i].Crime_ID == txt_C_ID.Text)
                    {
                        if (Crimes_obj.Crimess[i].Status == "Close")
                        {
                            if (!officer_obj.incrementnum_Assigned_Crimes(Crimes_obj.Crimess[i].Officer_ID))
                                return false;

                            Crimes_obj.Crimess[i].Status = "Open";
                           
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Crimes_obj.Crimess.Count; i++)
                {
                    if (Crimes_obj.Crimess[i].Crime_ID == txt_C_ID.Text)
                    {
                        if (Crimes_obj.Crimess[i].Status == "Open")
                        {
                            Crimes_obj.Crimess[i].Status = "Close";
                            officer_obj.decrementnum_Assigned_Crimes(Crimes_obj.Crimess[i].Officer_ID);
                            
                        }
                        break;

                    }
                }
            }

            return true;
        }
      
    
        //-----------------------------------------------------------------------------------------------------------------
      
        
        
        private void btn_Save_Update_Click(object sender, EventArgs e)
        {
            if (cmb_C_Statue.SelectedIndex == -1)
            {
                MessageBox.Show("Selecte Statue Of this Crime", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!Check_Status())
            {
                MessageBox.Show("Because This Officer have 10 Crime Open ", "This Crime Cannot Be Open Now ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string items = txt_Item.Text;
            if (items != "")
            {
                for (int i = 0; i < Crimes_obj.Crimess.Count; i++)
                {
                    if (Crimes_obj.Crimess[i].Crime_ID == txt_C_ID.Text)
                    {

                        Crimes_obj.Crimess[i].Item_Found += ',' + items;
                    }
                }
            }

            //if (btn_Update_img.Enabled == true )
            //{

            //    MessageBox.Show("Please Enter Another image", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //}
          Crimes_obj.saving_update();
            MessageBox.Show("Successfully Updated","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            panelviibles.Visible = false; 
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_ID_search_Click(object sender, EventArgs e)
        {
            if (!Crimes_obj.check_exist(txt_C_ID.Text))
            {
               // Visible_true();
                panelviibles.Visible = true;
                cmb_C_Statue.Text = Status;

            }
            else
                MessageBox.Show("Please Enter Valid id", "Crime id Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txt_Item_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_img_Click(object sender, EventArgs e)
        {
            //   save_image();
            if (save_image())
            {
                MessageBox.Show("Done Save ", "More", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_Update_img.Enabled = false;

                DialogResult res = MessageBox.Show("Do You Want To Add more Images ?", "More", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    btn_Update_img.Enabled = true;
                }
                else
                {
                    btn_Update_img.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Select Image ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // 
            } 
        }
        private void cmb_C_Statue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
