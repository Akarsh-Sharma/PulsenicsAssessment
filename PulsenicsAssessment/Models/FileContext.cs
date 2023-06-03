
using Microsoft.EntityFrameworkCore;


namespace PulsenicsAssessment.Models
{
    public class FileContext : DbContext
    {
        public FileContext(DbContextOptions<FileContext> options) : base(options)
        {

        }
        // reference to the Employees table in our database.
        // Each DbSet here references a table in the DB. 
        public DbSet<File> Files { get; set; }
    }
}
