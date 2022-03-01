using System.ComponentModel.DataAnnotations;

namespace BloodMVC.Models
{
    public class MvcBloodDetails
    {[Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public DateTime LastVaccination { get; set; }
        public DateTime BloodRecived { get; set; }
        public bool isVaccinate { get; set; }
        public int BloodId { get; set; }
        public int OrgId { get; set; }
        public int HemoglobinId { get; set; }
    }
}
