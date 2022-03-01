using System.ComponentModel.DataAnnotations;

namespace bloodbank23.model
{
    public class KindOfOrg
    {[Key]
        public int OrgId { get; set; }
        public string? OrgName { get; set; }
    }
}
