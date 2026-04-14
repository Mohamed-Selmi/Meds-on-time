using backend.Controllers;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace backend.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { 
            
        }      
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
{
    configurationBuilder
        .Properties<DateTimeOffset>()
        .HaveConversion<DateTimeOffsetConverter>();
}
        public DbSet<User> Users{ get; set;}
        public DbSet<Medication> Medications{ get; set;} 
    }
}