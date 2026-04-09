using System.Xml.Serialization;

namespace Reserve.Models
{
    [XmlRoot("Reserve")]
    public class ReserveData
    {
        [XmlArray("Animals")]
        [XmlArrayItem("Animal")]
        public List<Animal> Animals { get; set; }

        [XmlArray("Employees")]
        [XmlArrayItem("Employee")]
        public List<Employee> Employees { get; set; }

        [XmlArray("Feedings")]
        [XmlArrayItem("Feeding")]
        public List<Feeding> Feedings { get; set; }
    }
}
