using Microsoft.EntityFrameworkCore;
using ClaimApps.Models;
using Microsoft.Identity.Client;
namespace ClaimApps.Data
{
    public class ClaimContext : DbContext
    {
        public  ClaimContext(DbContextOptions<ClaimContext> options) : base(options) {

        }
           
           public DbSet<Claim> ClaimSet { get; set; }      
        }
    }

