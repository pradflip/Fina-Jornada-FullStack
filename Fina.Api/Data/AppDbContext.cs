using Fina.Api.Data.Mappings;
using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Fina.Api.Data
{
    // construtor primario
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        //public AppDbContext(DbContextOptions<AppDbContext> options)
        //   : base(options)
        //{}

        public DbSet<Category> Categories { get; set; } = null!; //null not
        public DbSet<Transaction> Transactions { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Em vez de:
            //modelBuilder.ApplyConfiguration(new CategoryMapping());
            //modelBuilder.ApplyConfiguration(new TransactionMapping());
    }
}
