using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class ReferenceItems
    {
        public ReferenceItems()
        {
            this.ItemsPricing = new HashSet<ItemsPricing>();
        }
        public int Id { get; set; }

        public int WPCode { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public int BankCode { get; set; }
        public bool Duplicated { get; set; }
        [ForeignKey("WPCode")]

        public virtual ICollection<ItemsPricing> ItemsPricing { get; set; }
    }
}
