using Microsoft.EntityFrameworkCore;

namespace NewProjectRestPrj.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() 
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base (options) { }
        public DbSet<Person> Pearson { get; set; }
    }
}
