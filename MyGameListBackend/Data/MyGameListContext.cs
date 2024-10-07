using Microsoft.EntityFrameworkCore;
using MyGameList.Models;

namespace MyGameList.Data
{
    public class MyGameListContext(DbContextOptions<MyGameListContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Tracker> Tracker => Set<Tracker>();
        public DbSet<TrackerCategory> TrackerCategory => Set<TrackerCategory>();
    }
}