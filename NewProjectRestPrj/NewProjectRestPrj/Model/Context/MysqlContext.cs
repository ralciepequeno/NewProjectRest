using Microsoft.EntityFrameworkCore;

namespace NewProjectRestPrj.Model.Context
{
    public class MysqlContext : DbContext
    {
        public MysqlContext() 
        {

        }
        public MysqlContext(DbContextOptions<MysqlContext> options) : base (options) { }
        public DbSet<Person> Pearson { get; set; }
    }
}
