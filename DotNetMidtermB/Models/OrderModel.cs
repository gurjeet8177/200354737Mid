namespace DotNetMidtermB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderModel : DbContext
    {
        public OrderModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Size1)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);
        }
    }
}
