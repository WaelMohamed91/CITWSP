using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace CITWSP
{
   
    public partial class UserControl_CrimeAdd : UserControl
    {
        Image file;
        Crime_Type crime_type_obj;
        Officer Officer_obj;
        Crimes Crimes_obj;
        Involved_people involve_obj;
        //****************************Support Functions 
        public void fil_Officers_ID()
        {
            for (int i = 0; i < Officer_obj.Officers.Count; i++)
            {
                if (Officer_obj.Officers[i].num_Assigned_Crimes < 10)
                    comb_officerID.Items.Add(Officer_obj.Officers[i].Officer_ID);
            }
        }


        public void fill_crime_name()
        {
            for (int i = 0; i < crime_type_obj.List_Types.Count; i++)
            {
                comb_type_name.Items.Add(crime_type_obj.List_Types[i].Type_Name);

            }

        }

        

        public bool  empty ()
        {
            if (txt_id.Text == "" || comb_type_name.Text == "" || comb_Status.Text == "" || txt_descrip.Text == "" || txt_itemfound.Text == "" || comb_Location.Text == "" || txt_locdetails.Text == "" || txt_IDinvol.Text == "" || comb_officerID.Text == ""||pictureBox2.Image==null)
            {
                MessageBox.Show("Please Enter All information about this crime ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;  
        }
        public bool check_involve_exist()
        {
            if (involve_obj.check_exist(txt_IDinvol.Text))
            {
                MessageBox.Show(" Please Add information about this  ", "This involve ID Not exist at Involved People Information ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
         

      public void clear ()
        {
            txt_id.Text = ""; comb_type_name.Text = ""; comb_Status.Text = ""; txt_descrip.Text = ""; txt_itemfound.Text = ""; comb_Location.Text = "" ; txt_locdetails.Text = ""; txt_IDinvol.Text = "";
            comb_officerID.Text = "";pictureBox2.Image=null ;
            Crimes_obj.Involved_People.Clear();
            txt_IDinvol.Enabled = true;
            
        }

        //*************************
        public UserControl_CrimeAdd()
        {
            InitializeComponent();
        }

        void save_image()
        {
            string f = txt_id.Text + "." + Crimes_obj.Num_Image + ".jpg";
            string folder = Environment.CurrentDirectory + "\\" + txt_id.Text;
            string path = System.IO.Path.Combine(folder, f);
            file.Save(path);
        }

        private void UserControl_CrimeAdd_Load(object sender, EventArgs e)
        {
            crime_type_obj = new Crime_Type();
            crime_type_obj.Load();
            Officer_obj = new Officer();
            Officer_obj.Lood_Officers();
            Crimes_obj = new Crimes();
            involve_obj = new Involved_people();
            involve_obj.load();
            Crimes_obj.Load();
           fill_crime_name();
            fil_Officers_ID();

        }

        private void btn_Moreinvo_Click(object sender, EventArgs e)
        {
            if (Crimes_obj.Involved_People.Contains(txt_IDinvol.Text))
            {
                MessageBox.Show("Please enter Different ID" , "This Involved Exist in this crime" ,MessageBoxButtons.OK , MessageBoxIcon.Stop);
                return;
                
            }
            if (!check_involve_exist())
                return;

            DialogResult res = MessageBox.Show("Do You Want To Add more Involved People ?", "More", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Crimes_obj.Involved_People.Add(txt_IDinvol.Text);

                txt_IDinvol.Text = "";

            }
            else
            {
               // Crimes_obj.Involved_People.Add(txt_IDinvol.Text);
              //  txt_IDinvol.Text = "";
                txt_IDinvol.Enabled = false;

            }
        }
      

        private void btn_Attachimg_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                pictureBox2.Image = file;
            }
            btn_Attachimg.Enabled = false; 
        }
       
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        { 
        }
        private void btn_Add_crime_Click(object sender, EventArgs e)
        {

            if (!empty())
                return;
              if (!Crimes_obj.check_exist(txt_id.Text))
               {
                   MessageBox.Show("Please Enter anthor ID", "Crime ID is already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
          
            String type = crime_type_obj.List_Types[comb_type_name.SelectedIndex].Type_ID;

            if (!check_involve_exist())
                return;

            if (Crimes_obj.Involved_People.Contains(txt_IDinvol.Text))
            {
                MessageBox.Show("Please enter Different ID", "This Involved Exist in this crime", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Directory.CreateDirectory(txt_id.Text);
            save_image();

            Crimes_obj.Involved_People.Add(txt_IDinvol.Text);

            Crimes_obj.Add_Crime(txt_id.Text, type, comb_Status.Text, txt_descrip.Text, 1, txt_itemfound.Text, comb_Location.Text, txt_locdetails.Text, Crimes_obj.Involved_People, comb_officerID.Text);
           
            if (comb_Status.Text == "Open")
            { Officer_obj.incrementnum_Assigned_Crimes(comb_officerID.Text); }


            MessageBox.Show("Successfuly Added ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Attachimg.Enabled = true; 


            clear();

           Crimes_obj = new Crimes();
            Crimes_obj.Load();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
