using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TabletopDirector.DataAccess.Models;

namespace TabletopDirector.DataAccess.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base() { }
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<GameMaster> GameMasters { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
    }
}
