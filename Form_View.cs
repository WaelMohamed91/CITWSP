using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CITWSP
{
    public partial class Form_View : Form
    {
        Crimes obj_img = new Crimes();
            public string id_select = UserControl_viewCrimecs.a;
         public Form_View()
        {
            InitializeComponent();
        }

        private void Form_View_Load(object sender, EventArgs e)
        {
            obj_img.Load();
            listView1.View = View.Details;
            listView1.Columns.Add("Crime image in this ID");
            listView1.Columns[0].Width = 258;
            ImageList img = new ImageList();
            img.ImageSize = new Size(255, 200);
            String[] paths = { };
            string folder = Environment.CurrentDirectory + "\\" +id_select ;
            paths = Directory.GetFiles(folder);

            foreach (String path in paths)
            {
                img.Images.Add(Image.FromFile(path));
            }

            listView1.SmallImageList = img;
            for (int i = 0; i < obj_img.Crimess.Count; i++) {
                if (obj_img.Crimess[i].Crime_ID == id_select)
                {
                    for (int j = 0; j < obj_img.Crimess[i].Num_Image; j++)
                {
                    listView1.Items.Add("Image", j);
                }
        }        }
        }
    }
}
