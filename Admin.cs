using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace CITWSP
{
    public class Admin
    {
        public string Admin_ID ;
        public string Admin_Name;
        [XmlIgnore]
        public List<Admin> List_Admin;
       
        public Admin (string id , string name ) { Admin_ID = id; Admin_Name = name;  }
        public Admin () { }
        public void Add_Admins (string id , string name )
        {
           
            Admin Ad = new Admin(id,name);
            List_Admin.Add(Ad);
            FileStream fs = new FileStream("Admain.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(List_Admin.GetType());
            

            se.Serialize(fs, List_Admin);
            fs.Close();
        }
        public void Load ()
        {
            List_Admin = new List<Admin>();
            FileStream fs = new FileStream("Admain.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(List_Admin.GetType());
            List_Admin = (List<Admin>)se.Deserialize(fs);

            fs.Close();
        }

        public int Check_Login(String id, String name )
        {
            for (int i = 0; i <List_Admin.Count; i++)
            {
                if (List_Admin[i] .Admin_ID == id )
                {
                    if (List_Admin[i].Admin_Name == name)
                    {
                        // login
                        return 1;
                    }
                    else // id is true but not match with name 
                        return 2;
                }
               
            }
            //id Error 
            return 3;

        }

    }
}
