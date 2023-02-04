using System.ComponentModel.DataAnnotations.Schema;

namespace day8solid.Models
{
    public class Dlocations
    {
      
        public string Dlocation { get; set; }
        [ForeignKey("Department")]
        public int? Dnum { get; set; }
        public virtual department? Department { get; set; }
    }
}
