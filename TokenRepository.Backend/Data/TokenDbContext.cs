using Microsoft.EntityFrameworkCore;
using TokenRepository.Backend.Data.Models;

namespace TokenRepository.Backend.Data
{
    public class TokenDbContext : DbContext
    {
        public TokenDbContext(DbContextOptions<TokenDbContext> options) : base(options)
        {

        }
        public DbSet<TokenBasis> TokenBasis { get; set; }
        public DbSet<SecurityLevelBasis> SecurityLevelBasis { get; set; }
    }
}
