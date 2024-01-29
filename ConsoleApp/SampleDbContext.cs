using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }
    }
}

