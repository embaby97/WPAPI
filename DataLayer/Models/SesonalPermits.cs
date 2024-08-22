using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class SesonalPermits
    {
        [Key]
        public int Id { get; set; }
        public string EgyptianCompanyName { get; set; }
        public string ForeignCompanyName { get; set; }
        public string ListNumber { get; set; }
        public bool IsPaied { get; set; }
    }
}
