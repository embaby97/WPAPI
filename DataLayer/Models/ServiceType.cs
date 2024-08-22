using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        //Unique
        public string Code { get; set; }
        public string Name { get; set; }


        //public List<Request> Requests { get; set; }
    }
}
