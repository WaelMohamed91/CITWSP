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
    public partial class UserControl_Officers : UserControl
    {
        Officer obj;
        

        public UserControl_Officers()
        {
            InitializeComponent();
        }

        bool empty()
        {
            if (txt_offic_ID.Text == "" && txt_offc_name.Text == "")
            {
                MessageBox.Show("ID and Name is empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_offic_ID.Text == "")
            {
                MessageBox.Show("ID is Empty ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_offc_name.Text == "")
            {
                MessageBox.Show("Name is Empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return true;

        }
        private void btn_saveOffice_Click(object sender, EventArgs e)
        {
            if (!empty())
                return;
                for (int i = 0; i < obj.Officers.Count; i++)
                   {
                       Officer x = new Officer();
                       x = obj.Officers[i];
                       if (x.Officer_ID == txt_offic_ID.Text)
                       {
                           MessageBox.Show("This ID Already Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           return;
                       }
                   }
       
                obj.Add_Officer(txt_offic_ID.Text, txt_offc_name.Text);
            MessageBox.Show("Successfuly Added" , "Done" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            txt_offc_name.Text = "";
            txt_offic_ID.Text = "";



        }

        private void UserControl_Officers_Load(object sender, EventArgs e)
        {
            obj = new Officer();
            //  obj.Lood_Officers();
          
        }
    }
}
