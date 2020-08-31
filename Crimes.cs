using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization; 

namespace CITWSP
{
    [Serializable]

    public class Crimes
    {
       
        public String Crime_ID;
        public String Crime_Type ;
        public String Status;
        public String Description;
        public int Num_Image;
        public String Item_Found;
        public String Location ;
        public String Location_Detais;
        public String Officer_ID; 
        public List<String> Involved_People;
        [XmlIgnore]
        public List<Crimes> Crimess;
        [XmlIgnore]
        String del_OfficerID;
        public Crimes () { Crimess = new List<Crimes>(); Involved_People = new List<string>(); del_OfficerID = "-1";   } 
        public Crimes (String crime_id , String Type_ID  , String  State , String des , int images , String item , String location , String details , List <string> involve , String officer_id)
        {
            Involved_People = new List<string>();
            Crime_ID = crime_id;
            Crime_Type = Type_ID;
            Status = State;
            Description = des;
            Num_Image = images;
            Item_Found = item;
            Location = location;
            Location_Detais = details;
            Involved_People = involve;
            Officer_ID = officer_id; 
        }
       
       
        //public Crimes  Update  (Crimes obj)
        //{

        //    return obj;
        //}
        public String  Delete  (String id)
        {
            for(int i = 0; i < Crimess.Count; i++)
            {
                Crimes obj_c = new Crimes();
                obj_c = Crimess[i];
                if (obj_c.Crime_ID == id)
                {
                    if (obj_c.Status=="Open")
                    del_OfficerID= Crimess[i].Officer_ID;
                /*  String folder = Environment.CurrentDirectory + "\\" + id;

                    for (int j = 0; j < Crimess[i].Num_Image ; j++)
                    {
                       // string jj = j.ToString();
                        string f = id + "." + j + ".jpg";
                        string path = Path.Combine(folder, f);
                        File.Delete(path);
                        
                    }

                    Directory.Delete(folder);*/
                    Crimess.RemoveAt(i);
                    break;
                }

            }
            FileStream fs = new FileStream("Crimes.xml", FileMode.Truncate);
            fs.Close();
            save();
            
            return del_OfficerID;
        }
        public void Load ()
        {

            FileStream fs = new FileStream("Crimes.xml", FileMode.OpenOrCreate);
            
            XmlSerializer se = new XmlSerializer(Crimess.GetType());
            Crimess = (List<Crimes>)se.Deserialize(fs);

            fs.Close();

        }
        public void save()
        {
            FileStream fs = new FileStream("Crimes.xml", FileMode.Truncate);
            XmlSerializer se = new XmlSerializer(Crimess.GetType());
            se.Serialize(fs, Crimess);
            fs.Close();

        }
        public void Add_Crime (String crime_id, String Type_ID, String State, String des, int images, String item, String location, String details, List<string> involve, String officer_id)
        {
            Crimes ad = new Crimes( crime_id, Type_ID,  State,  des, images, item, location, details,  involve,  officer_id);
            Crimess.Add(ad);
            save();

        }
        public bool check_exist(String id)
        {
            for (int i = 0; i < Crimess.Count; i++)
            {
                Crimes Np = new Crimes ();
                Np = Crimess[i];
                if (Np.Crime_ID == id)
                {
                    UserControl_CrimeUpdate.Status = Np.Status;
                    return false;
                }
                    
            }
            return true;
        }


        public void incrementimage(string id)
        {
            for (int i = 0; i < Crimess.Count; i++)
            {
                if (Crimess[i].Crime_ID == id)
                {

                    Crimess[i].Num_Image++;
                    break;
                }
            }
            save();
        }

        public void saving_update()
        {
            FileStream fs = new FileStream("Crimes.xml", FileMode.Truncate);
            XmlSerializer se = new XmlSerializer(Crimess.GetType());
            se.Serialize(fs, Crimess);
            fs.Close();
        }

        public void Delete_Image(String id)
        {
            String folder = Environment.CurrentDirectory + "\\" + id;
            for (int i = 0; i < Crimess.Count; i++)
            {

                if (Crimess[i].Crime_ID == id)
                {
                    for (int j = 0; j < Crimess[i].Num_Image; j++)
                    {
                        
                        string f = id + "." + j + ".jpg";
                        string path = Path.Combine(folder, f);
                        File.Delete(path);

                    }
                    break;
                }

              

            }
            Directory.Delete(folder);
        }


    }
}

