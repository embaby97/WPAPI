using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class InvoiceIntervals
    {
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        public double Price { get; set; }
        public virtual string ItemsPricingString { get; set; }

        public int QualificationId { get; set; }
       // public virtual Qualification Qualification { get; set; }
        //1 to m 
        public int InvoiceId { get; set; }
       // public virtual Invoice Invoice { get; set; }
        //1 to m
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }

    }
}