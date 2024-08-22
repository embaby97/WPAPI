using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class WorkPermits
    {
        public int Id { get; set; }
        public Guid guid { get; set; }
        public int BrancheId { get; set; }
        public int DocumentNumber { get; set; }
        public string PassportNumber { get; set; }
        public string MobileNumber { get; set; }
        public string NID { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public string WorkPermitNumber { get; set; }
        public string Job { get; set; }
        public int  JobTypeId { get; set; }
        public bool Aproved { get; set; } = false;
        public bool Disapproved { get; set; } = false;
        public bool Delivered { get; set; } = false;
        public bool Deleted { get; set; } = false;
        public bool Urgent { get; set; } = false;
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Column(TypeName = "Date")]

        public DateTime? QualificationChangeDate { get; set; }
        //public DateTime? QualificationChangeDate { get; set; }

        public DateTime ExpirationDate { get; set; }
        public Branches Branche { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string DeletedBy { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int GovernmentId { get; set; }
        public Government Government { get; set; }
        public int QualificationId { get; set; }
        public Qualification Qualification { get; set; }
        public int PermitAddressId { get; set; }
       //// public int CompanyId { get; set; }
        public virtual PermitAddress PermitAddress { get; set; }
        public bool PreviousPermits { get; set; }
        public List<PermitState> PermitStates { get; set; } = new List<PermitState>();
        public List<RequestStates> RequestStates { get; set; }

        //public virtual PermitState CurrentStste { get; set; }
        #region new part
        [Column(TypeName = "Date")]

        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date")]

        public DateTime EndDate { get; set; }
        public bool IsPaid { get; set; }
        public virtual Invoice Invoice { get; set; }
        public string CurrentState { get; set; }
        public ServiceType ServiceType { get; set; }

        
        #endregion
    }
    public class PermitAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int GovernmentId { get; set; }
        public Government Government { get; set; }
        public int PoliceDepartmentId { get; set; }
        public PoliceDepartment PoliceDepartment { get; set; }

    }
}
