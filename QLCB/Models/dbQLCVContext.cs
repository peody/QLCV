using Microsoft.EntityFrameworkCore;
#nullable disable

namespace QLCB.Models
{
    public partial class dbQLCVContext : DbContext
    {
        public dbQLCVContext()
        {
        }

        public dbQLCVContext(DbContextOptions<dbQLCVContext> options)
            : base(options)
        {
        }

        //Thu thập thông tin làm phần mềm
        public virtual DbSet<tbCongViec> tbCongViecs { get; set; }
        // Unable to generate entity type for table 'dbo.Docs' since its primary key could not be scaffolded. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"),  p=>p.EnableRetryOnFailure());

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbCongViec>(entity =>
            {
                entity.Property(e => e.IdCongViec).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
