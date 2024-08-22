using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class PermitState
    {
        public int Id { get; set; }
        public int PermitId { get; set; }
       // public WorkPermits3 Permit { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public string CreatedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        //public int Counter { get; set; }

    }
}