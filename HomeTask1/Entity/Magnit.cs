using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HomeTask1.Entity
{
    public partial class Magnit : DbContext
    {
        public Magnit()
            : base("name=Magnit")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<fio> fio { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fio>()
                .Property(e => e.MiddleName)
                .IsFixedLength();

            modelBuilder.Entity<fio>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<fio>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.fio)
                .HasForeignKey(e => e.Fio_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fio>()
                .HasMany(e => e.User)
                .WithRequired(e => e.fio)
                .HasForeignKey(e => e.Fio_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Order)
                .Map(m => m.ToTable("ListOfProductsInOrder").MapLeftKey("OrderId").MapRightKey("ProductId"));
        }
    }
}
