using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class RequestStates
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public string StateCode { get; set; }


       // public Request Request { get; set; }
        public Guid RequestId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
