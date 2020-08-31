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
    public partial class UserControl_DeleteCrime : UserControl
    {
        Crimes delobj;

        Officer officer; 
        
        public Crimes crime = new Crimes();
        
        public UserControl_DeleteCrime()
        {
            InitializeComponent();
        }
        public bool empty()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter id of this crime ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void lbl_Del_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Remove_Crim_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter ID", " Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


         if (delobj.check_exist(textBox1.Text))
            {
                MessageBox.Show("Enter An Exist id , this is not available ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // String folder = Environment.CurrentDirectory + "\\" + textBox1.Text;
            // Delete(folder);


            delobj.Delete_Image(textBox1.Text);
            String officer_id= delobj.Delete(textBox1.Text);
          

            if (officer_id != "-1")
                officer.decrementnum_Assigned_Crimes(officer_id);

           
            MessageBox.Show("Done Delete Crime ID : " + textBox1.Text, " Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
           
        }

        private void UserControl_DeleteCrime_Load(object sender, EventArgs e)
        {
            delobj = new Crimes();
            delobj.Load();
            officer = new Officer();
            officer.Lood_Officers();
        }
    }
}
