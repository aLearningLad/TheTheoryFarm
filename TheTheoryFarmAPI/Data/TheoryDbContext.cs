﻿using Microsoft.EntityFrameworkCore;
using TheTheoryFarmAPI.Models.Domain;

namespace TheTheoryFarmAPI.Data
{
    public class TheoryDbContext : DbContext
    {
        public TheoryDbContext(DbContextOptions dbContextOptions): base (dbContextOptions)
        {
        }

        public DbSet<Theory> Theories { get; set; }
    }
}
