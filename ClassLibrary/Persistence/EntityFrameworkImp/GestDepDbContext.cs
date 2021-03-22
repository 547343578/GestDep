using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestDep.Entities;
//using GestDep.Domain;
using System.Data.Entity;

namespace GestDep.Persistence
{
    public class GestDepDbContext : DbContextISW
    {
        public GestDepDbContext() : base("Name=GestDepDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static GestDepDbContext()
        {
            //Database.SetInitializer<VehicleRentalDbContext>(new CreateDatabaseIfNotExists<VehicleRentalDbContext>());
            Database.SetInitializer<GestDepDbContext>(new DropCreateDatabaseIfModelChanges<GestDepDbContext>());
            //Database.SetInitializer<VehicleRentalDbContext>(new DropCreateDatabaseAlways<VehicleRentalDbContext>());
            //Database.SetInitializer<VehicleRentalDbContext>(new VehicleRentalDbInitializer());
            //Database.SetInitializer(new NullDatabaseInitializer<VehicleRentalDbContext>());
        }

        public DbSet<CityHall> CityHalls { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Primary keys with non conventional name
            /*
            modelBuilder.Entity<Person>().HasKey(p => p.Dni);
            modelBuilder.Entity<Customer>().HasKey(c => c.Dni);
            modelBuilder.Entity<CreditCard>().HasKey(c => c.Digits);
            */
            // Classes with more than one relationship
            /*
            modelBuilder.Entity<Reservation>().HasRequired(r => r.PickUpOffice).WithMany(o => o.PickUpReservations).WillCascadeOnDelete(false);
            modelBuilder.Entity<Reservation>().HasRequired(r => r.ReturnOffice).WithMany(o => o.ReturnReservations).WillCascadeOnDelete(false);
            */
        }

    }

}
