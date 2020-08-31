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
    public partial class Officer_Functions : Form
    {
        public Officer_Functions()
        {
            InitializeComponent(); 
          
        }

        

        
        private void btn_ChechkUpdate_Click(object sender, EventArgs e)
        {
            
            panel_offic.Controls.Clear();
            UserControl_CheckUpdate obj_Update = new UserControl_CheckUpdate();
            panel_offic.Controls.Add(obj_Update);
        }

        private void btn_Viewinvoled_Click_1(object sender, EventArgs e)
        {
            panel_offic.Controls.Clear();
            UserControl_viewinvold obj_inv = new UserControl_viewinvold();
            panel_offic.Controls.Add(obj_inv);
        }

        private void btn_View_Crime_Click(object sender, EventArgs e)
        {
            panel_offic.Controls.Clear();
            UserControl_viewCrimecs obj = new UserControl_viewCrimecs();
            panel_offic.Controls.Add(obj);
        }

        private void panel_offic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Officer_Functions_Load(object sender, EventArgs e)
        {
           
        }
    }
}
