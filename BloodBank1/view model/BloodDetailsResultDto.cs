using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BloodBank1.view_model
{
    public class BloodDetailsResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime LastVaccination { get; set; }
        public DateTime BloodRecived { get; set; }
        public bool isVaccinate { get; set; }
        [DisplayName("Blood Name")]
        public string BloodId { get; set; }
        public string OrgId { get; set; }
        public string HemoglobinId { get; set; }
    }
}
