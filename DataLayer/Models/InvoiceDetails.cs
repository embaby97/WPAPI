namespace DataLayer.Models
{
    public class InvoiceDetails
    {
        public int Id { get; set; }
        //public int InvoiceId { get; set; }
        public int ItemsPricingId { get; set; }
        public double ItemPrice { get; set; }

        public int InvoiceIntervalsId { get; set; }
        //public string Note { get; set; }
        //public virtual InvoiceIntervals InvoiceInterval { get; set; }
    }
}
