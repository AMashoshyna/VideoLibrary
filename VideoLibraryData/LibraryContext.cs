using VideoLibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace VideoLibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
