using DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }


        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Government> Government { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<PoliceDepartment> PoliceDepartment { get; set; }
        public virtual DbSet<PermitAddress> PermitAddress { get; set; }
        public virtual DbSet<BankCodes> BankCodes { get; set; }
        public virtual DbSet<QualificationVsWPCode> QualificationVsWPCodes { get; set; }
        //public virtual DbSet<Requirement> Requirements { get; set; }
        //public virtual DbSet<RequirementsDetailes> RequirementsDetailes { get; set; }
        public virtual DbSet<ItemsPricing> ItemsPricing { get; set; }
        public virtual DbSet<ReferenceItems> ReferenceItems { get; set; }
        public virtual DbSet<SesonalPermits> SesonalPermits { get; set; }
        public virtual DbSet<State> States { get; set; }
        //public virtual DbSet<PermitState> PermitStates { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<QualificationVsWPCode> QualificationVsWPCode { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceIntervals> InvoiceIntervals { get; set; }
        // public DbSet<FinancialEstimatePerYear> FinancialEstimatePerYear { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestStates> RequestStates { get; set; }
        public virtual DbSet<Religions> Religions { get; set; }
        public virtual DbSet<Person> person { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        // public virtual DbSet<WorkPermit> workPermit { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Permit> Permit { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<JobsInEgypt> JobsInEgypt { get; set; }
        public virtual DbSet<ContractDescriptionType> ContractDescriptionTypes { get; set; }
        public virtual DbSet<Financiallylisted> Financiallylisted { get; set; }
        public virtual DbSet<JobTypes> JobTypes { get; set; }
        public virtual DbSet<FinancialClearanceType> FinancialClearanceType { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Request>()
            .HasOne(r => r.JobTypes)
            .WithMany()
            .HasForeignKey(r => r.JobTypesId)
            .OnDelete(DeleteBehavior.Cascade); // Assuming CASCADE deletion behavior, modify as needed

            modelBuilder.Entity<Request>()
           .Property(r => r.JobTypesId)
           .HasDefaultValue(750); // Change 'defaultValue' to your desired default value from the JobTypes table



            modelBuilder.Entity<QualificationVsWPCode>()
          .HasKey(a => new { a.QualificationId, a.WPCodeId });
            modelBuilder.Entity<BankCodes>().HasIndex(u => u.ReferenceItemIds).IsUnique();
            modelBuilder.Entity<ReferenceItems>().HasIndex(u => u.WPCode).IsUnique();
            //modelBuilder.Entity<Permit>().HasIndex(u => u.WorkPermitNumber).IsUnique();
            //modelBuilder.Entity<WorkPermit>().HasIndex(u => u.WorkPermitNumber).IsUnique();
            modelBuilder.Entity<ServiceType>().HasIndex(u => u.Code).IsUnique();





            modelBuilder.Entity<Request>()
                .HasOne(r => r.ServiceType)
                .WithMany()
                .HasForeignKey(r => r.ServiceTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Request>()
            .HasOne(r => r.Person)
            .WithMany()
            .HasForeignKey(r => r.PersonId)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<State>().HasIndex(u => u.StateCode).IsUnique();
            modelBuilder.Entity<Person>()
            .HasOne(p => p.Government)
            .WithMany()
            .HasForeignKey(p => p.GovernmentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<RequestStates>()
                      .HasOne(rs => rs.State)
                      .WithMany(s => s.RequestStates)
                      .HasForeignKey(rs => rs.StateId);

            ///
            modelBuilder.Entity<Invoice>()
                  .HasOne(x => x.Request)
                  .WithOne(x => x.Invoice).IsRequired(false);




            modelBuilder.Entity<Request>()
                  .HasOne(r => r.Person)
                  .WithMany(p => p.Requests)
                  .HasForeignKey(rs => rs.PersonId);
            //modelBuilder.Entity<Request>()
            //      .HasOne(r => r.Permit)
            //      .WithOne(p => p.Request);
            #region
            modelBuilder.Entity<Passport>()
                      .HasOne(rs => rs.Person)
                      .WithMany(s => s.Passports)
                      .HasForeignKey(rs => rs.PersonId);
            //.HasForeignKey(rs => rs.PersonNId);


            modelBuilder.Entity<Passport>()
         .HasMany(c => c.Permits)
         .WithOne(e => e.Passport)
         .HasForeignKey(e => e.PassportNumber)
         .IsRequired();
            #endregion

            modelBuilder.Entity<Person>()
            .Property(p => p.BirthDate)
            .HasComputedColumnSql(@"CASE 
                WHEN LEFT(NId, 1) IN ('3', '4')
                    THEN CONVERT(datetime, '20' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)
                ELSE CONVERT(datetime, '19' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)
                END");
        }




    }
}