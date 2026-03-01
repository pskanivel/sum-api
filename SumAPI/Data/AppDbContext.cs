using Microsoft.EntityFrameworkCore;
using SumApi.Models;
using System.Collections.Generic;

namespace SumApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SumRecord> SumRecords { get; set; }
    }
}