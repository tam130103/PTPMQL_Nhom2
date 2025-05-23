using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Models.Entities;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<MemberUnit> MemberUnit { get; set; } = default!;
    }
}