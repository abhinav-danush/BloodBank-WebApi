using System.ComponentModel.DataAnnotations;

namespace BlooodBank.model
{
    public class Hemoglobin
    {[Key]
        public int HemoglobinId { get; set; }
        public string HemoglobinLevel { get; set; }
    }
}
