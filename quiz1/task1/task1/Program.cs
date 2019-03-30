using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run)
            {
                string filename = "save.dat";
                string s = Console.ReadLine();
                if(s == "WRITE")
                {
                    string login = Console.ReadLine();
                    string password = Console.ReadLine();
                    string[] data = new string[2];
                    data[0] = login;
                    data[1] = password;
                    
                    Save(data, filename);
                }
                if(s == "READ")
                {
                    string[] data = Load(filename);
                    string login = data[0];
                    string password = data[1];
                    Console.WriteLine("Login: " + login + "   Password: " + password);
                }
                else
                {
                    run = false;
                }
            }
        }
        static void Save(string[] data, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(string[]));
            xml.Serialize(fs, data);
            fs.Close();
        }
        static string[] Load(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(string[]));
            string[] data = xml.Deserialize(fs) as string[];
            fs.Close();
            return data;
        }
    }
}
