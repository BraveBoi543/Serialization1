using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization1
{
    [XmlRoot("New Employees", Namespace ="www.nerdinc.n")]
    public class Employee
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlAttribute("Full Name")]
        public string Name { get; set; }
        [XmlAttribute("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlAttribute("Todays Date")]
        public DateTime EntryDate { get; set; }
        [XmlIgnore]
        public string JobRole { get; set; }
    }
}
