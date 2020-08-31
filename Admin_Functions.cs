using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITWSP
{
    public partial class Admin_Functions : Form
    {
        public Admin_Functions()
        {
            InitializeComponent();
        }

        
        private void btn_Cris_Click(object sender, EventArgs e)
        {
           
            pnl_Admin.Controls.Clear();
            UserControl_CrimeType obj_CrimeType = new UserControl_CrimeType();
            pnl_Admin.Controls.Add(obj_CrimeType);
            // al statement deh ht5ly al user control ya5od kool al form , blash hna kda , katbha 34an t3rafoha
            //   pnl_Admin.Dock = DockStyle.Fill; 
        }

        private void btn_Crime_Click_1(object sender, EventArgs e)
        {
            Crimes_Functions obj = new Crimes_Functions();
            obj.Show();
        }

        private void btn_Officer_Click_1(object sender, EventArgs e)
        {
            pnl_Admin.Controls.Clear();
            UserControl_Officers obj_officer = new UserControl_Officers();
            pnl_Admin.Controls.Add(obj_officer);
         
        }

        private void btn_involved_Click_1(object sender, EventArgs e)
        {
            pnl_Admin.Controls.Clear();
            UserControl_Involved_Info obj_Involved = new UserControl_Involved_Info();
            pnl_Admin.Controls.Add(obj_Involved);
        }

        private void btn_addadmin_Click(object sender, EventArgs e)
        {
            pnl_Admin.Controls.Clear();
            UserControl_Add_Admin obj = new UserControl_Add_Admin();
            pnl_Admin.Controls.Add(obj); 

        }

        private void boinc_Click(object sender, EventArgs e)
        {
            pnl_Admin.Controls.Clear();
            UserControl1_chart ob_chart = new UserControl1_chart();
            pnl_Admin.Controls.Add(ob_chart);
        }
    }
}
