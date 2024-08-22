using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class BankCodes
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public double Price { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }

        public string ReferenceItemIds { get; set; }
    }
}