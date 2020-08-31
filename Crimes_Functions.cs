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
    public partial class Crimes_Functions : Form
    {
        public Crimes_Functions()
        {
            InitializeComponent();
        }

        private void btn_UpdateCrime_Click(object sender, EventArgs e)
        {
            pan_Crime.Controls.Clear();
            UserControl_CrimeUpdate obj_crimeUpdate = new UserControl_CrimeUpdate();
            pan_Crime.Controls.Add(obj_crimeUpdate);
        }

        private void btn_addCrime_Click(object sender, EventArgs e)
        {
            pan_Crime.Controls.Clear();
            UserControl_CrimeAdd obj_crimeAdd = new UserControl_CrimeAdd();
            pan_Crime.Controls.Add(obj_crimeAdd);
        }

        private void btn_deleteCrime_Click(object sender, EventArgs e)
        {
            pan_Crime.Controls.Clear();
            UserControl_DeleteCrime obj_crimeDelete = new UserControl_DeleteCrime();
            pan_Crime.Controls.Add(obj_crimeDelete);
        }
    }
}
