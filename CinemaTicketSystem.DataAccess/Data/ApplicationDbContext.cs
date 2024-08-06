using CinemaTicketSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories").HasKey(pk => pk.Id);
                c.Property(i => i.Id).HasColumnName("id");
                c.Property(n => n.Name).HasColumnName("name");
                c.Property(d => d.Description).HasColumnName("description");
                c.Property(ca => ca.CreatedAt).HasColumnName("createdAt");
                c.Property(ua => ua.UpdatedAt).HasColumnName("updatedAt");
                c.Property(da => da.DeletedAt).HasColumnName("deletedAt");
            });


            Category[] categories = new Category[]
            {
                new Category {
                    Name = "Action",
                    Description = "Action type",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null,
                    DeletedAt = null },

                new Category {
                    Name = "Drama",
                    Description = "Drama type",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null,
                    DeletedAt = null
                }
            };

            modelBuilder.Entity<Category>()
                .HasData(categories);
        }
    }
}
