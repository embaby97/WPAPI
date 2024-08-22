using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class Passport
    {
        [Key]
        public string PassportNumber { get; set; }
        public Person Person { get; set; }
        public Guid PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InsertedDate { get; set; }

        public string InsertedBy { get; set; }
       // public ICollection<WorkPermit> WorkPermits { get; set; }
        public ICollection<Permit> Permits { get; set; }


    }
}
