using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace CITWSP
{
    public partial class Login : Form
    {
        public static String Officer_ID;
       public Login()
        {

            Thread t = new Thread(new ThreadStart(StartUP));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }
        public void StartUP()
        {
            Application.Run(new Form_Splash());
        }
        // True to admin and false to officer 
        public bool flag = true; 

      
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            panel_log.Visible = false;
            txt_ID.Text = "";
            txt_Name.Text = "";

            panel_log.Visible = true;
            flag = true; 
        }
        bool empty()
        {
            if (txt_ID.Text == "" && txt_Name.Text == "")
            {
                MessageBox.Show("ID and Name is empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_ID.Text == "")
            {
                MessageBox.Show("ID is Empty ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Name.Text == "")
            {
                MessageBox.Show("Name is Empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        

        private void btn_AsOfficer_Click(object sender, EventArgs e)
        {
            panel_log.Visible = false;
            txt_ID.Text = "";
            txt_Name.Text = "";
            panel_log.Visible = true;
            flag = false; 
        }

        

        private void btn_loginn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Admin obj = new Admin();
                obj.Load();
                if (!empty())
                    return;
                if (obj.Check_Login (txt_ID.Text , txt_Name.Text) == 1)
                {
                    Admin_Functions f = new Admin_Functions();
                    f.Show();
                }
                else if (obj.Check_Login(txt_ID.Text, txt_Name.Text ) == 2 )
                    MessageBox.Show("Name Not match with this ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
               
                    MessageBox.Show("ID Not Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (!empty())
                    return;
                Officer obj = new Officer();
                obj.Lood_Officers();
                Officer_ID = txt_ID.Text;
                if (obj.Check_Login(txt_ID.Text, txt_Name.Text) == 1)
                {
                    Officer_Functions f = new Officer_Functions();
                    f.Show();
                }
                else if (obj.Check_Login(txt_ID.Text, txt_Name.Text) == 2)
                    MessageBox.Show("Name Not match with this ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    MessageBox.Show("ID Not Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                
            }
        }
    }
}
