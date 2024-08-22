using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class WorkPermits3
    {
        public int Id { get; set; }
        public int BrancheId { get; set; }
        public string PassportNumber { get; set; }
        public string MobileNumber { get; set; }
        public string NID { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public string WorkPermitNumber { get; set; }
        public string Job { get; set; }
        public bool Aproved { get; set; } = false;
        public bool Disapproved { get; set; } = false;
        public bool Delivered { get; set; } = false;
        public bool Deleted { get; set; } = false;
        public bool Urgent { get; set; } = false;
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
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
        public PermitAddress PermitAddress { get; set; }

        public static implicit operator WorkPermits3(WorkPermits v)
        {
            throw new NotImplementedException();
        }
    }
    //public class PermitAddress
    //{
    //    public int Id { get; set; }
    //    public string Address { get; set; }
    //    public int GovernmentId { get; set; }
    //    public Government Government { get; set; }
    //    public int PoliceDepartmentId { get; set; }
    //    public PoliceDepartment PoliceDepartment { get; set; }

    //}
}
