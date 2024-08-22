using System;

namespace DataLayer.Models
{
    public class Financiallylisted
    {
        public int Id { get; set; }
        //[Key, Column(Order = 1)]
        public Guid PersonId { get; set; }
        public string Note { get; set; }
        //[Key, Column(Order = 2)]
        public double Value { get; set; }
     
        //[Key, Column(Order = 3)]
        public int PermitId { get; set; }
        //[Key, Column(Order = 4)]
        public DateTime IntervalStartDate { get; set; }
        //[Key, Column(Order = 5)]
        public DateTime IntervalEndDate { get; set; }
        public bool FinanciallyClear { get; set; }
        public DateTime IsertionDate { get; set; }
    }
}
