using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiCRUD.Controllers;
using WebApiCRUD.Models;

namespace WebApiCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Company> Company { get; set; }

        public DbSet<Country> Country { get; set; }
        public IEnumerable<CountryController> CountryController { get; internal set; }
    }
}
