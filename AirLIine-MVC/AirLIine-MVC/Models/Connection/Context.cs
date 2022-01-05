using Microsoft.EntityFrameworkCore;
using AirLIine_MVC.Models;

namespace Models.Models {
    public class Context : DbContext {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base (options) { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         base.OnConfiguring(optionsBuilder);
      }

        public DbSet<TblPlan> TblPlans { get; set; }
        public DbSet<TblUser> TblUsers { get; set; }
        public DbSet<TblReservation> TblReservations { get; set; }
        public DbSet<TblCompany> TblCompanies { get; set; }
    }
}

