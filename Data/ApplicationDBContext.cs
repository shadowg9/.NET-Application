using Microsoft.EntityFrameworkCore;
using MomoWebApplication.Models;

namespace MomoWebApplication.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        
    } 
}
