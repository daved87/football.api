using Microsoft.EntityFrameworkCore;


namespace footballApi.Models
{
    public class FootballContext : DbContext
    { 
        public FootballContext()
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
    }
}