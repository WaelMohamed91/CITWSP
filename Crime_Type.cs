using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CITWSP
{
  public  class Crime_Type
    {
        public string Type_ID;
        public string Type_Name;
        [XmlIgnore]
        public List<Crime_Type> List_Types;
        public Crime_Type (string id , string name) { Type_ID = id; Type_Name = name;}
           
        
        public Crime_Type () { List_Types = new List<Crime_Type>(); }  

          public  void Add_Type (String id , String name)
        {
          
            Crime_Type oo = new Crime_Type(id, name);
            List_Types.Add(oo);
            XmlSerializer se = new XmlSerializer(List_Types.GetType());
            FileStream fs = new FileStream("Typecrimes.xml", FileMode.OpenOrCreate);

            se.Serialize(fs, List_Types);
            fs.Close();

           
        }
        public bool Check_Login ()
        {
            
            return false;
        }
        public void Load ()
        {
            FileStream fs = new FileStream("Typecrimes.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(List_Types.GetType());
            List_Types = (List<Crime_Type>)se.Deserialize(fs);

            fs.Close();

        }

    }
}
