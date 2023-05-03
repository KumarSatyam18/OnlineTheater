using eTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<eTickets.Models.Actor> Actors { get; set; }
        public DbSet<eTickets.Models.Movie> Movies { get; set; }
        public DbSet<eTickets.Models.Actor_Movie> Actors_Movies { get; set; }
        public DbSet<eTickets.Models.Cinema> Cinemas { get; set; }
        public DbSet<eTickets.Models.Producer> Producers { get; set; }


        //Orders related tables
        public DbSet<eTickets.Models.Order> Orders { get; set; }
        public DbSet<eTickets.Models.OrderItem> OrderItems { get; set; }
        public DbSet<eTickets.Models.ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<eTickets.Models.Login> Login { get; set; }
        public DbSet<eTickets.Models.Register> Register { get; set; }
    }
}
