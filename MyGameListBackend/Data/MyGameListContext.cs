using Microsoft.EntityFrameworkCore;
using MyGameList.Models;
using MyGameListBackend.Migrations;

namespace MyGameList.Data
{
    public class MyGameListContext(DbContextOptions<MyGameListContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Tracker> Tracker => Set<Tracker>();
        public DbSet<TrackerCategory> TrackerCategory => Set<TrackerCategory>();
        public DbSet<Game> Game => Set<Game>();
        public DbSet<Genre> Genre => Set<Genre>();
    }
}