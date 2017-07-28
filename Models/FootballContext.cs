using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace footballApi.Models
{
    public class FootballContext : DbContext
    { 
        private IConfigurationRoot _config;
        public FootballContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:FootballContextConnection"]);
            base.OnConfiguring(optionsBuilder);
        }
    }
}