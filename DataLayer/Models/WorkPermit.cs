using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class WorkPermit
    {
        public int Id { get; set; }
        public string NId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int DocumentNumber { get; set; }
        public string WorkPermitNumber { get; set; }
        public string Job { get; set; }

        public Country Country { get; set; }
        public int PermitAddressId { get; set; }

        public int QualificationId { get; set; }
        public Qualification Qualification { get; set; }
   

        public DateTime InsertedDate { get; set; }

        public string InsertedBy { get; set; }
        //navigation Prop
        //public string PassportNumber { get; set; }
        //public Passport Passport { get; set; }
       // public List<Request> Requests { get; set; }
        public PermitAddress PermitAddress { get; set; }
      
        [Column(TypeName = "Date")]

        public DateTime? QualificationChangeDate { get; set; }
        public bool IsPaid { get; set; }
        public bool? IsApproved { get; set; }


    }
}
