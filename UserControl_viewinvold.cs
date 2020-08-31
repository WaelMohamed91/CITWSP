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
    public partial class UserControl_viewinvold : UserControl
    {
        String s2;
        Dictionary<String, int> involve_Repeated;
        Dictionary<String, String> name = new Dictionary<String, String>();
        Crime_Type Crime_Type_obj = new Crime_Type();
       
        List<Involved_people> Logical_Order = new List<Involved_people>();

        Involved_people involve_obj = new Involved_people();

        Crimes Crime_obj = new Crimes(); 
        //****************

         public void fill_RepeatDic(String type )
        {
            
            involve_Repeated.Clear();
            for (int i = 0; i < Crime_obj.Crimess.Count; i++)
            {
                if (name[Crime_obj.Crimess[i].Crime_Type]==type)
                {
                  for (int j = 0; j< Crime_obj.Crimess[i].Involved_People.Count;j++)
                    {
                        String s = Crime_obj.Crimess[i].Involved_People[j];
                       
                        bool flag = false; 
                       if (s[s.Length-1] == '$')
                        {
                            for (int w = 0; w <= s.Length - 2; w++)
                            {
                                s2 += s[w].ToString();

                            }
                            
                            flag = true; 
                        }
                        if (flag)
                        {
                            try { involve_Repeated.Add(s2, 1); }
                            catch { involve_Repeated[s2]++; }
                            s2 = "";
                        }
                        else
                        {

                            try { involve_Repeated.Add(s, 1); }
                            catch { involve_Repeated[s]++; }
                        }
                     
                    }
                }
            }

        }
        void Fill_Logical_Order()
        {
            Logical_Order.Clear();
            int maxi;
            int count = involve_Repeated.Count;
            String key;
            for (int i = 0; i < count; i++)
            {
                maxi = involve_Repeated.ElementAt(0).Value;
                key = involve_Repeated.ElementAt(0).Key;

                for (int j = 0; j < involve_Repeated.Count; j++)
                {
                    if (involve_Repeated.ElementAt(j).Value >= maxi)
                    {
                        maxi = involve_Repeated.ElementAt(j).Value;
                        key = involve_Repeated.ElementAt(j).Key;
                    }

                }
                involve_Repeated.Remove(key);
                Logical_Order.Add(involve_obj.involve_Dic[key]);
            }
        }
        void fill_names()
        {
            for (int i = 0; i < Crime_Type_obj.List_Types.Count; i++)
            {

                name[Crime_Type_obj.List_Types[i].Type_ID] = Crime_Type_obj.List_Types[i].Type_Name;
            } }
        void Ser_ComboBox()
        {
            for (int i = 0; i <name.Count; i++)
            {
                comboBox1.Items.Add(Crime_Type_obj.List_Types[i].Type_Name);
            }
        }

        //****************
        public UserControl_viewinvold()
        {
            InitializeComponent();
        }


        private void UserControl_viewinvold_Load(object sender, EventArgs e)
        {
            involve_Repeated = new Dictionary<string, int>();
            Crime_Type_obj.Load();
            Crime_obj.Load();
            involve_obj.load();

            fill_names();

            involve_obj.Set_Dic();
            Ser_ComboBox();
            
             
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fill_RepeatDic(comboBox1.Text);
            Fill_Logical_Order();
         
            for (int i = 0; i < Logical_Order.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Logical_Order[i].Involv_ID;
                dataGridView1.Rows[i].Cells[1].Value = Logical_Order[i].Involv_Name;
                dataGridView1.Rows[i].Cells[2].Value = Logical_Order[i].Involv_Location;
                dataGridView1.Rows[i].Cells[3].Value = Logical_Order[i].Invo_loc_details;
                dataGridView1.Rows[i].Cells[4].Value = Logical_Order[i].Age;


            }
            if (Logical_Order.Count ==0 )
            {
                MessageBox.Show("There is no people involved in crime " + comboBox1.Text, "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Form_pic_invol f_i = new Form_pic_invol();            string imagename = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Image img;
            img = Image.FromFile(Environment.CurrentDirectory + "\\" + "Involved"+"\\" +imagename +".jpg");
            f_i.pictureBox1.Image = img;
            f_i.ShowDialog();
           ;
        }
    }
}
