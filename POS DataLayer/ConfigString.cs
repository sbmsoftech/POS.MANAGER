using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace POS_DataLayer
{
    public class ConString
    {

        public static string DB_User { get; set; }


        public static string DB_Password { get; set; }


        public static string DB_Name { get; set; }


        public static string DB_Server { get; set; }


        public static string DB_Provider { get; set; }
        public static void docreatesetting(settings stt)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\"))
            {
                string savepath = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\";

                XmlSerializer serializer = new XmlSerializer(typeof(settings));

                using (TextWriter writer = new StreamWriter(savepath + "SqlConfig.xml"))
                {
                    serializer.Serialize(writer, stt);
                }

            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\");
                string savepath = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\";

                XmlSerializer serializer = new XmlSerializer(typeof(settings));

                using (TextWriter writer = new StreamWriter(savepath + "SqlConfig.xml"))
                {
                    serializer.Serialize(writer, stt);
                }
            }


        }
        public static bool docallsetting()
        {
            bool rtype = false;
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\"))
            {
                string savepath = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "POS\\";

                string[] dirs = Directory.GetFiles(savepath);
                foreach (var file in dirs)
                {


                    if (file.Contains("SqlConfig"))
                    {


                        XmlSerializer serializer = new XmlSerializer(typeof(settings));


                        using (TextReader reader = new StreamReader(savepath + "SqlConfig.xml"))
                        {

                            object obj = serializer.Deserialize(reader);
                            settings stt = (settings)obj;

                            DB_Name = stt.DB_Name;
                            DB_Password = stt.DB_Password;
                            DB_Server = stt.DB_Server;
                            DB_User = stt.DB_User;
                            DB_Provider = stt.DB_Provider;

                            rtype = true;

                        }


                    }
                    else
                    {

                        rtype = false;
                    }


                }
                return rtype;
            }
            else
            {
                return false;
            }
        }

        public static string getconstring()
        {
            string str = string.Empty;
            if (docallsetting())
            {
                str = "Server='" + ConString.DB_Server + "';";
                str += "Database='" + ConString.DB_Name + "';";
                str += "User Id='" + ConString.DB_User + "';";
                str += "Password='" + ConString.DB_Password + "';";

                EntityConnectionStringBuilder stb = new EntityConnectionStringBuilder();
                stb.Metadata = "res://*/StoreEntity.csdl|res://*/StoreEntity.ssdl|res://*/StoreEntity.msl";
                stb.Provider = "System.Data.SqlClient";
                stb.ProviderConnectionString = str + "MultipleActiveResultSets=True;App=EntityFramework";
                //stb.Name  = "System.Data.EntityClient";
                return stb.ToString();

            }
            else
            {
                return str;
            }
        }
    }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("configuration")]
    public class settings
    {
        [System.Xml.Serialization.XmlElement("DB_User")]
        public string DB_User { get; set; }

        [System.Xml.Serialization.XmlElement("DB_Password")]
        public string DB_Password { get; set; }

        [System.Xml.Serialization.XmlElement("DB_Name")]
        public string DB_Name { get; set; }

        [System.Xml.Serialization.XmlElement("DB_Server")]
        public string DB_Server { get; set; }

        [System.Xml.Serialization.XmlElement("DB_Provider")]
        public string DB_Provider { get; set; }
    }
}
