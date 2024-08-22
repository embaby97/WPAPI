using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
   public class Person
    {
        public Guid Id { get; set; }

        [MaxLength(14)]
        public string NId { get; set; }
        public string Name { get; set; }
        //public DateTime BirthDate { get; set; }
        // BirthDate is a computed column in the database
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime BirthDate { get; private set; }
        public string BirthPlace { get; set; }
        public int? GovernmentId { get; set; }
        public Government Government { get; set; }
        public string Mobile { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? QualificationChangeDate { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime LastEditDate { get; set; }

        //nav prop
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public Religions Religion { get; set; }
        public int ReligionId { get; set; }


        public List<Passport> Passports { get; set; }
        public List<Request> Requests { get; set; }
        public List<Financiallylisted> financiallylisted { get; set; }
    }

    
}
