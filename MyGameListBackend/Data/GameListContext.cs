using Microsoft.EntityFrameworkCore;
using MyGameList.Models;

namespace MyGameList.Data
{
    public class GameListContext : DbContext
    {
        public GameListContext(DbContextOptions<GameListContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Game> Games => Set<Game>();
    }
}