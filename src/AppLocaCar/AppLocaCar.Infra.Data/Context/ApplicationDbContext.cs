using AppLocaCar.Domain.Entities;
using AppLocaCar.Infra.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppLocaCar.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CarRentDays> CarRentDays { get; set; }


        ////https://docs.microsoft.com/pt-br/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechangesasync?view=efcore-5.0
        ////Salva todas as alterações feitas neste contexto no banco de dados.
        //public override int SaveChanges() => this.SaveChanges(true);
        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
        //    this.SaveChangesAsync(true, cancellationToken);


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new CarRentDaysConfiguration());


            //var entityTypes = builder.Model.GetEntityTypes().ToList();

            //// Disable cascade delete
            //var foreignKeys = entityTypes
            //.SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            //foreach (var foreignKey in foreignKeys)
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}
        }
    }
}
