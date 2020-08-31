using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace CITWSP
{
    public partial class UserControl_Add_Admin : UserControl
    {
        Admin objA ;
        public UserControl_Add_Admin()
        {
            InitializeComponent();
        }

    bool empty ()
        {
            if (txt_AdminID.Text == "" && txt_Adminname.Text == "")
            {
                MessageBox.Show("ID and Name is empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_AdminID.Text == "")
            { MessageBox.Show("ID is Empty ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;  }
            else if (txt_Adminname.Text == "")
            {  MessageBox.Show("Name is Empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);return false; 
        }
            return true;
            
        }
        private void UserControl_Add_Admin_Load(object sender, EventArgs e)
        {
            objA = new Admin();
            objA.Load();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

       
        private void btn_AddAdm_Click_1(object sender, EventArgs e)
        {
            if (!empty())
                return; 
            for (int i = 0; i < objA.List_Admin.Count; i++ )
            {
                Admin x = new Admin();
              x=  objA.List_Admin[i];
                if (x.Admin_ID == txt_AdminID.Text )
                {
                    MessageBox.Show("This ID Already Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                } 

            }
            objA.Add_Admins(txt_AdminID.Text, txt_Adminname.Text);
            txt_AdminID.Text = "";
            txt_Adminname.Text = "";
            MessageBox.Show("Successfuly Added ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        private void txt_Adminname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
