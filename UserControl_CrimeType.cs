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
    public partial class UserControl_CrimeType : UserControl
    {

        //    public  List<Crime_Type> List_Types; 
        Crime_Type obj;

    
        public UserControl_CrimeType()
        {
            InitializeComponent();
        }

        public bool empty()
        {

        
            if (txt_CrimeID.Text == "")
            {
                MessageBox.Show("ID Text Box is empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txt_CrimeName.Text == "" && txt_CrimeName.Enabled == true)
            {
                MessageBox.Show("Name Text Box is empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UserControl_CrimeType_Load(object sender, EventArgs e)
        {
            obj = new Crime_Type();

           
        }

        private void btn_Check_Click_2(object sender, EventArgs e)
        {
            obj.Load();

            if (!empty())
                return; 
            string id = txt_CrimeID.Text;
      


         for (int i =0; i < obj.List_Types.Count; i ++)
            {
                Crime_Type x = new Crime_Type();
               x= obj.List_Types[i];
              
                if (x.Type_ID == id)
                {
                    MessageBox.Show("This ID Already Exist", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            
            btn_AddCrime.Enabled = true;
            txt_CrimeName.Enabled = true; 
        }

        private void btn_AddCrime_Click(object sender, EventArgs e)
        {
            if (!empty())
                return;
            obj.Add_Type(txt_CrimeID.Text, txt_CrimeName.Text); 
            
            txt_CrimeName.Text = "";
            txt_CrimeID.Text = "";
            MessageBox.Show("Successfuly Added ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_AddCrime.Enabled = false;
            txt_CrimeName.Enabled = false;

        }

        private void txt_CrimeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
