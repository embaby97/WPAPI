using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Requirement
    {
        public Requirement()
        {
            this.RequirementsDetailes = new HashSet<RequirementsDetailes>();
        }
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        public virtual ICollection<RequirementsDetailes> RequirementsDetailes { get; set; }

    }
}
