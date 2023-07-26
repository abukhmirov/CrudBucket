using CrudBucketMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBucketMVC.DataAccess
{
    public class CrudBucketContext : DbContext
    {
        public DbSet<GameCompany> GameCompanies { get; set; }
        public CrudBucketContext(DbContextOptions<CrudBucketContext> options) : base(options)
        {
            
    }
    }
}
