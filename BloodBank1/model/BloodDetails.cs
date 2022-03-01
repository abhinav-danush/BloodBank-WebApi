using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BloodBank1.model
{
    public class BloodDetails
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public  int Number { get; set; }
        [Required]
        public DateTime LastVaccination { get; set; }
        [Required]
        public DateTime BloodRecived { get; set; }
        [Required]
        public bool isVaccinate { get; set; }
        [Required]       
        public int BloodId{ get; set; }
        [Required]       
        public int OrgId { get; set; }
        [Required]       
        public int HemoglobinId { get; set; }
    }
}
