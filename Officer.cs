using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CITWSP
{
    public class Officer
    {
        public string Officer_ID;
        public string Officer_Name;

        [XmlIgnore]
        public List <Crimes> Close ;
        [XmlIgnore]
        public List<Crimes> Open ;
        [XmlIgnore]
        public List<Officer> Officers;
      
       
        public int num_Assigned_Crimes; 
        public Officer () { num_Assigned_Crimes = 0; Officers = new List<Officer>();
            Open = new List<Crimes>();
            Close = new List<Crimes>();
        } 
        public Officer (String id , string name ) { Officer_ID = id; Officer_Name = name; num_Assigned_Crimes = 0; }
        public void Save ()
        {
         
            FileStream fs = new FileStream("Officer2.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(Officers.GetType());
            se.Serialize(fs, Officers);
            fs.Close();
        }
        public void Add_Officer (String id , String name )
        {
        
            Officer Ad = new Officer (id, name);
            Officers.Add(Ad);
            Save();
        
        }
    
        public void Lood_Officers () {
            
                FileStream fs = new FileStream("Officer2.xml", FileMode.OpenOrCreate);
                XmlSerializer se = new XmlSerializer(Officers.GetType());
                Officers = (List<Officer>)se.Deserialize(fs);

                fs.Close();
           
        }
        public int Check_Login(String id, String name)
        {
            for (int i = 0; i < Officers.Count; i++)
            {
                if (Officers[i].Officer_ID == id)
                {
                    if (Officers[i].Officer_Name == name)
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


        public bool incrementnum_Assigned_Crimes (string id )
        {
            for (int i = 0; i < Officers.Count ; i++ ) {
                if (Officers[i].Officer_ID== id && Officers[i].num_Assigned_Crimes == 10)
                {
                    return false;
                       break; 
                }
                else if (Officers[i].Officer_ID == id)
                {
                    Officers[i].num_Assigned_Crimes++;
                    break;
                }
            }
            Save();
            return true;
        }
        public void decrementnum_Assigned_Crimes(string id)
        {
            for (int i = 0; i < Officers.Count; i++)
            {
                if (Officers[i].Officer_ID == id)
                {

                    Officers[i].num_Assigned_Crimes--;
                    break;
                }
            }

            Save();


        }
        public void Lood_My_Crimes ()
        {
            Crimes Crime_obj = new Crimes();
            FileStream fs = new FileStream("Crimes.xml", FileMode.OpenOrCreate);

            XmlSerializer se = new XmlSerializer(Crime_obj.Crimess.GetType());

            Crime_obj.Crimess = (List<Crimes>)se.Deserialize(fs);
        
            fs.Close();
            for (int i = 0; i< Crime_obj.Crimess .Count; i++)
            {
                if (Crime_obj.Crimess[i].Officer_ID == Login.Officer_ID)
                {
                    if (Crime_obj.Crimess[i].Status == "Open")
                        Open.Add(Crime_obj.Crimess[i]);
                    else
                        Close.Add(Crime_obj.Crimess[i]);
                }
            }

        }
        public void saving_update_officer()
        {
           
            FileStream fs = new FileStream("Officer2.xml", FileMode.Truncate);
            fs.Close();
            FileStream fss = new FileStream("Officer2.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(Officers.GetType());
            se.Serialize(fss, Officers);
            fss.Close();
        }
    }
}
