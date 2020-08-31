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
    public partial class UserControl1_chart : UserControl
    {
        Crimes c = new Crimes();
        Crime_Type t = new Crime_Type();

        Dictionary<string, int> D = new Dictionary<string, int>();
        Dictionary<string, string> name = new Dictionary<string, string>();
        public UserControl1_chart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_chart_Load(object sender, EventArgs e)
        {
            c.Load();
            t.Load();
            for (int i = 0; i < t.List_Types.Count; i++)
            {
                D.Add(t.List_Types[i].Type_Name, 0);
                name[t.List_Types[i].Type_ID] = t.List_Types[i].Type_Name;
            }


            int count;
            for (int i = 0; i < D.Count; i++)
            {
                count = 0;

                for (int j = 0; j < c.Crimess.Count; j++)
                {
                    if (name[c.Crimess[j].Crime_Type] == D.Keys.ElementAt(i))
                    {
                        count += c.Crimess[j].Involved_People.Count;
                    }
                }
                D[t.List_Types[i].Type_Name] = count;

            }
            for (int i = 0; i < D.Count; i++)
            {
                this.chart1.Series["Crimes_Type"].Points.AddXY(D.Keys.ElementAt(i), D.Values.ElementAt(i));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
    

