using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CITWSP
{
    public class Involved_people
    {
        public String Involv_ID;
        public String Involv_Name;
        public String Involv_Location;
        public String Invo_loc_details;
        //public String Image_path;
        public String Age;

        [XmlIgnore]
        public List<Involved_people> invo_list;
        [XmlIgnore]
        public Dictionary<String, Involved_people> involve_Dic;

        public Involved_people() { invo_list = new List<Involved_people>();  }
        public Involved_people(String id, String name, String details, String involv_loction, String age)
        {
            Involv_ID = id;
            Involv_Name = name;
            Involv_Location = involv_loction;
            Invo_loc_details = details;
            //Image_path = image;
            Age = age;
        }
      

        public void load()
        {
         
            FileStream fs = new FileStream("InvolvedPeople.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(invo_list.GetType());
            invo_list = (List<Involved_people>)se.Deserialize(fs);
            fs.Close();
        }
        public void Set_Dic()
        {
            involve_Dic = new Dictionary<string, Involved_people>();
            for (int i = 0;i<invo_list.Count;i++)
            {
                involve_Dic[invo_list[i].Involv_ID] = invo_list[i];

            }

        }
        public bool check_exist(String id) {
            for (int i = 0; i < invo_list.Count; i++)
            {
                Involved_people Np = new Involved_people();
                Np = invo_list[i];
                if (Np.Involv_ID == id)
                    return false;
            }
            return true;
        }
        
    
        public void Add_invo(Involved_people obj)
        {
            
            Involved_people Ad = new Involved_people(obj.Involv_ID, obj.Involv_Name, obj.Involv_Location,obj.Invo_loc_details, obj.Age);
            invo_list.Add(Ad);

            FileStream fs = new FileStream("InvolvedPeople.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(invo_list.GetType());
            se.Serialize(fs, invo_list);
            fs.Close();
            
        }

    }
}
