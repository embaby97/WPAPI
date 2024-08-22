using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        //public bool IsPaid { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? QualificationChangeDate { get; set; }
        //public bool Urgent { get; set; }
        //public bool Deleted { get; set; }
        //public string DeletedBy { get; set; }

        //navigation prop 1 => M
        //[MaxLength(14)]
        //public string NId { get; set; }
        //public Guid PersonId { get; set; }
        public int QualificationId { get; set; }// need to remove
        public DateTime InseartionDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }
        //public int StatusId { get; set; }
        //public State State { get; set; }
        public double Total { get; set; }
        public ICollection<InvoiceIntervals> InvoiceIntervals { get; set; }
        public Guid RequestId { get; set; }
     
        public Request Request { get; set; }



    }
}
