using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<delivery> deliveries { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<order_info> order_info { get; set; }
        public virtual DbSet<payment> payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<feedback>()
                .Property(e => e.feedback1)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<order_info>()
                .Property(e => e.delivery_address)
                .IsUnicode(false);
        }
    }
}
