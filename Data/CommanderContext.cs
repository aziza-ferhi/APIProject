using Microsoft.EntityFrameworkCore;
using commander.Models;

namespace commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }
        public DbSet<Command> commands { get; set; }
    }
}