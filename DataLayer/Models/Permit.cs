using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class Permit
    {
        public int Id { get; set; }
        public string NId { get; set; }
        public Passport Passport { get; set; }
        public string PassportNumber { get; set; }
        public int DocumentNumber { get; set; }
        //[Index(IsUnique = true)]
        public string WorkPermitNumber { get; set; }
        //public string Job { get; set; }
        //public string JobInEgypt { get; set; }

        //public Country Country { get; set; }
        //public int CountryId { get; set; }
        public int PermitAddressId { get; set; }

        public int QualificationId { get; set; }
        public Qualification Qualification { get; set; }
  
        public virtual List<Request> Request { get; set; }
        //public Guid RequestId { get; set; }

        //public List<Request> Requests { get; set; }
        public PermitAddress PermitAddress { get; set; }
 

        // [Column(TypeName = "Date")]
        public DateTime? QualificationChangeDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public int JobsInEgyptId { get; set; }

        ////public ContractDescriptionType ContractDescriptionType { get; set; }
        //public int ContractDescriptionTypeId { get; set; }

        public DateTime? EndOfVacationDate { get; set; }
        public DateTime InsertedDate { get; set; }

        public string InsertedBy { get; set; }
        //public bool IsPaid { get; set; }
        //public bool? IsApproved { get; set; }


        //public JobsInEgypt JobsInEgypt { get; set; }
      

    }
}
