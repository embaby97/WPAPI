using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class RequirementsDetailes
    {
        //public RequirementsDetailes()
        //{
        //    this.Service = new HashSet<Service>();
        //}
        public int Id { get; set; }
        public int RequirementId { get; set; }
        public int? QualificationId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        public double Price { get; set; }
        public bool IsDuplicated { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsCurruntValue { get; set; }
        [Column(TypeName = "Date")]

        public DateTime StartDate { get; set; }
        [DisplayFormat( ApplyFormatInEditMode = true)]
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }

      
        public Requirement Requirement { get; set; }
        //public int ServiceProductId { get; set; }
        //public virtual ICollection< Service> Service { get; set; }



        [Column(TypeName = "Date")]
        public DateTime InsertionDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? UpdateDate { get; set; }

    }
}
