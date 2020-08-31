using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITWSP
{
    public partial class UserControl_CheckUpdate : UserControl
    {//***********************
        Officer Officer_obj;
        Crimes temp;
        Crimes Crimes_obj = new Crimes();
        public bool Select_ID()
        {
            if (comb_IDcrimeOfc.Text != "")
            { panel_suspect.Visible = true; return true; }
            else
            {
                MessageBox.Show("Select Crime ID Which You Want to Update", "Please Select Your Crime ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void updateInvolve()
        {
            for (int i = 0; i < checkedList_suspect.CheckedItems.Count; i++)
            {
                for (int j = 0; j < Crimes_obj.Involved_People.Count; j++)
                {
                    if (Crimes_obj.Involved_People[j] == checkedList_suspect.CheckedItems[i].ToString())
                    {
                        
                        if (Crimes_obj.Involved_People[j][Crimes_obj.Involved_People[j].Length-1 ] != '$')
                        Crimes_obj.Involved_People[j] += "$";
                        else
                        {
                            label2.Text = "The Involved pepole Has ID : " + Crimes_obj.Involved_People[j] ;
                            label3.Text = "you already choose it as a susbect so he still Suspect and this crime Closed ";
                            label2.Visible = true;
                            label3.Visible = true; 

                        }
                    }
                }
            } }
        public void  clear ()
        {
            MessageBox.Show("Done Update At Crime ID : " + comb_IDcrimeOfc.Text, "Done UpDate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            checkedList_suspect.Items.Clear();
            comb_IDcrimeOfc.Text = "";
            panel_suspect.Visible = false;

        }

        //************************
        public UserControl_CheckUpdate()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (!Select_ID())
                return;
            checkedList_suspect.Items.Clear();
            Crimes_obj = Officer_obj.Open[comb_IDcrimeOfc.SelectedIndex];
            for (int i = 0; i < Crimes_obj.Involved_People.Count; i++)
            {
                checkedList_suspect.Items.Add(Crimes_obj.Involved_People[i]);

            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserControl_CheckUpdate_Load(object sender, EventArgs e)
        {
            Officer_obj = new Officer();
            Officer_obj.Lood_My_Crimes();

           
            for (int i = 0; i < Officer_obj.Open.Count; i++)
            {
                comb_IDcrimeOfc.Items.Add(Officer_obj.Open[i].Crime_ID);
            }
            
        }

        private void btn_savesuspect_Click(object sender, EventArgs e)
        {
            
            if (checkedList_suspect.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select ID Which You Need to convert to Susbect", "Please Select Involve ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                Crimes_obj.Status = "Close";
           
                 updateInvolve();
                temp = new Crimes();
                temp.Load();
                String off_id =  temp.Delete(Crimes_obj.Crime_ID);
                temp.Add_Crime(Crimes_obj.Crime_ID, Crimes_obj.Crime_Type, Crimes_obj.Status, Crimes_obj.Description, Crimes_obj.Num_Image, Crimes_obj.Item_Found, Crimes_obj.Location, Crimes_obj.Location_Detais, Crimes_obj.Involved_People, Crimes_obj.Officer_ID);
          
                Officer_obj.decrementnum_Assigned_Crimes(off_id);
            clear();


            }

        private void checkedList_suspect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comb_IDcrimeOfc_SelectedIndexChanged(object sender, EventArgs e)
        {
           Officer_obj.Lood_Officers();
        }
    }
    }

