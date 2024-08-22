using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class State
    {
        public int Id { get; set; }
        //Unique
        public string StateCode { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public List<RequestStates> RequestStates { get; set; }
    }
}