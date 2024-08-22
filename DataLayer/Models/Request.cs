using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class Request
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
   

        //navigation property
        //0 or 1
        public int BrancheId { get; set; }
        public Branches Branche { get; set; }
        //public int WorkPermitId { get; set; }
        //public WorkPermit WorkPermit { get; set; }  
        public int PermitId { get; set; }
        public Permit Permit { get; set; }
        // 1 to *
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

        public Invoice Invoice { get; set; }
        //public int InvoiceId { get; set; }
        public Person Person { get; set; }
      
       // public string Job { get; set; }
        public string JobInEgypt { get; set; }
        public string CompanyName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public JobTypes JobTypes { get; set; }
        public int JobTypesId { get; set; }
        public int JobsInEgyptId { get; set; }
        public int ContractDescriptionTypeId { get; set; }

        public bool Approved { get; set; }
        public bool Disapproved { get; set; }
        //public bool Canceled { get; set; }
        //public bool Paid { get; set; }
        public bool Urgent { get; set; }
        public List<RequestStates> RequestStates { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
