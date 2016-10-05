using Microsoft.EntityFrameworkCore;

namespace MyApp.Models
{
    public class MyDbContext : DbContext {
        
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}