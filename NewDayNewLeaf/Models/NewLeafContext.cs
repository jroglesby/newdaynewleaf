using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewDayNewLeaf.Models
{
    public class NewLeafContext : DbContext
    {
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<FishTime> FishTimes { get; set; }
        public DbSet<FishLocation> FishLocations { get; set; }
        public DbSet<ShadowSize> ShadowSize { get; set; }
        public DbSet<FishRarity> FishRarity { get; set; }

    }
}