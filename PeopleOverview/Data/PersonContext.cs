using Microsoft.EntityFrameworkCore;

namespace PeopleOverview.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }
        public DbSet<PeopleOverview.Models.Person>? People { get; set; }
    }
}