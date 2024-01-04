using AuthDemo.Api.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Api.Contexts
{
    public class AuthDemoDbContext:IdentityDbContext
    {

        public AuthDemoDbContext(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }



    }
}
