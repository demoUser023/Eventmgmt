using EventManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace Database.Connection;

public class EventDbContext : DbContext
{
    public EventDbContext(DbContextOptions<EventDbContext> option) : base(option)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<Registration> Registration{ get; set; }


}