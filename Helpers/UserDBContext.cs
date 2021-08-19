using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_JWT.Authentication;
using WebApi_JWT.Models;
using WebApi_JWT.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApi_JWT.Utils
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<User> users { get; set; }
  
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        public class DbContextFactory : IDesignTimeDbContextFactory<UserDBContext>
        {
            public UserDBContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UserDBContext>();
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Todo;Integrated Security=True");

                return new UserDBContext(optionsBuilder.Options);
            }
        }
    }
}
