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
    public partial class UserControl_viewCrimecs : UserControl
    {
        Officer off;
        public static string a;
        public UserControl_viewCrimecs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells[0].Value);
                if (Directory.Exists(Environment.CurrentDirectory + "\\" + a))
                {

                    Form_View F = new Form_View();
                    F.ShowDialog();
                }
                else
                {
                    MessageBox.Show("no image in this");
                    return;
                }
            }
        }

        private void UserControl_viewCrimecs_Load(object sender, EventArgs e)
        {
            off = new Officer();
            off.Lood_My_Crimes();
            
           
        }

        public DataGridViewCell Cmb { get; set; }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < off.Open.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = off.Open[i].Crime_ID;
                dataGridView1.Rows[i].Cells[1].Value = off.Open[i].Crime_Type;
                dataGridView1.Rows[i].Cells[2].Value = off.Open[i].Item_Found;
                dataGridView1.Rows[i].Cells[3].Value = off.Open[i].Location;
                dataGridView1.Rows[i].Cells[4].Value = off.Open[i].Location_Detais;
                dataGridView1.Rows[i].Cells[5].Value = off.Open[i].Description;
                for (int j = 0; j < off.Open[i].Involved_People.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[6].Value += off.Open[i].Involved_People[j] + "--";
                }

                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < off.Close.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = off.Close[i].Crime_ID;
                dataGridView1.Rows[i].Cells[1].Value = off.Close[i].Crime_Type;
                dataGridView1.Rows[i].Cells[2].Value = off.Close[i].Item_Found;
                dataGridView1.Rows[i].Cells[3].Value = off.Close[i].Location;
                dataGridView1.Rows[i].Cells[4].Value = off.Close[i].Location_Detais;
                dataGridView1.Rows[i].Cells[5].Value = off.Close[i].Description;
                for (int j = 0; j < off.Close[i].Involved_People.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[6].Value += off.Close[i].Involved_People[j] + "--";
                }

                dataGridView1.AllowUserToAddRows = false;
            }
        }
    }
}
