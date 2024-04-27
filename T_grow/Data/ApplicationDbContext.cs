using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T_grow.Models;

namespace T_grow.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
                
        }
        public DbSet<TreatMentModel> TreatMents { get; set; }


    }
}
