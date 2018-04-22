using Microsoft.EntityFrameworkCore;

namespace events.Models
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users {get;set;}

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }
        public DbSet<Company> Companies { get; set; }


    }
}