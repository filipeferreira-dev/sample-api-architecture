using Domain.Models.Entities;
using Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class SampleContext : DbContext
    {
        #region Properties

        public DbSet<Product> Products { get; private set; }

        #endregion


        #region Constructors

        public SampleContext(DbContextOptions<SampleContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        #endregion

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //TODO: Retrive conectionString from appSettings.json
        //    optionsBuilder.UseSqlServer(@"Server=tcp:sample-arch.database.windows.net,1433;Initial Catalog=SampleArchDataBase;Persist Security Info=False;User ID=user;Password=atlas@111;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }
    }
}
