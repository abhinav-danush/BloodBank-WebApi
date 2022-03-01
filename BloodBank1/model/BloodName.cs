using System.ComponentModel.DataAnnotations;

namespace bloodbank23.model
{
    public class BloodName
    {[Key]
        public int BloodId { get; set; }
        public string? BType { get; set; }
    }
}
