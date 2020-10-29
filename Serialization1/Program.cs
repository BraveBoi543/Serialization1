using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serialization1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //emp.ID = 123;
            //emp.Name = "Joseph Catanzaro";
            //emp.SSNumber = 153638465;
            //emp.EntryDate = DateTime.Now;
            //emp.JobRole = "Ninja";

            


            string FilePath = "C:/Temp/";
            string FileName = "Genin.Xml";

            //TextWriter writer = new StreamWriter(FilePath + FileName);

            //XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name} \nEmployee SS#: {emp.SSNumber} \nDate Created: {emp.EntryDate}");
            }

            Console.ReadLine();
        }
    }
}
