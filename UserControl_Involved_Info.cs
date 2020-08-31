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

namespace CITWSP
{
    public partial class UserControl_Involved_Info : UserControl
    {
        Image File;
        public Involved_people obj_inv;
        public UserControl_Involved_Info()
        {
            InitializeComponent();
        }
        //*******************************************
        //to save image in spicefic tip

        void saveimg()
        {
                string f = txt_invol_ID.Text + ".jpg";
           // string folder = Environment.CurrentDirectory + "\\Involved" + "\\" + txt_invol_ID.Text ;
            string folder = Environment.CurrentDirectory + "\\Involved";

            string path = System.IO.Path.Combine(folder, f);
                Image a = pictureBox1.Image;
 
                a.Save(path);
        }
        
        
        bool empty()
        {
            if (txt_invol_ID.Text == " " || txt_nameinv.Text == "" || txt_details.Text == "" || txt_age.Text == "" ||comb_involv_loc.SelectedIndex==-1||pictureBox1.Image== null)
            {
                MessageBox.Show("Data Not Full", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else 
                return true;
        }
        void ClearHandWriten()
        {
            txt_invol_ID.Text = "";
            txt_nameinv.Text = "";
            txt_details.Text = "";
            comb_involv_loc.SelectedIndex = -1;
            txt_age.Text = "";
        }
        //*******************************************
        private void UserControl_Involved_Info_Load(object sender, EventArgs e)
        {
            obj_inv = new Involved_people();
          obj_inv.load();
        }

        private void btn_saveinvoled_Click(object sender, EventArgs e)
        {
            if (!empty())
                return;
            string li = comb_involv_loc.SelectedItem.ToString();

           if (!obj_inv.check_exist(txt_invol_ID.Text))
            { MessageBox.Show("This ID Already Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

          
            Involved_people obj = new Involved_people(txt_invol_ID.Text,txt_nameinv.Text,li, txt_details.Text, txt_age.Text);
            obj_inv.Add_invo(obj);

            saveimg();
            MessageBox.Show("Successfuly Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_involve_img.Enabled = true;
            ClearHandWriten();



        }

        private void btn_involve_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
              
                pictureBox1.Image = File;
            }
            btn_involve_img.Enabled = false; 
        }

        private void btn_img_Click(object sender, EventArgs e)
        {

        }
    }
}
