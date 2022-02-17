using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Data;

public class ContactsContext : DbContext
{
    public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
    {
    }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public DbSet<Contact> Contacts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(
            new Contact {Id = 1, FirstName = "Ziad", LastName = "Salem"},
            new Contact {Id = 2, FirstName = "Nour", LastName = "Nafea"},
            new Contact {Id = 3, FirstName = "Ali", LastName = "Hassan"});
    }

}