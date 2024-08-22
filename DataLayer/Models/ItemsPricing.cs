using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class ItemsPricing
    {
        public int Id { get; set; }
        public int WPCode { get; set; }
        public double Price { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Start { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true)]
        [Column(TypeName = "Date")]
        public DateTime? End { get; set; }

        public virtual ReferenceItems ReferenceItems { get; set; }
    }
}
