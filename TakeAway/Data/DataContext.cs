using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Data;

namespace TakeAway
{
  public  class DataContext :DbContext
    {
        public DataContext():base("TakeAwayDB")
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CallUser>().HasMany(x => x.FinishedOrders).WithRequired(x => x.CallUser).WillCascadeOnDelete(false);
            //modelBuilder.Entity<SenderUser>().HasMany(x => x.FinishedOrders).WithRequired(x => x.SenderUser).WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<CallUser> CallUsers { get; set; }
        public virtual DbSet<SenderUser> SenderUsers { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FinishedOrder> FinishedOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        //public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
  


    }
}
