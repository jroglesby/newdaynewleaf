using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewDayNewLeaf.Models
{
    public class Fish
    {
        public int FishID { get; set; }
        public string FishName { get; set; }
        public int Price { get; set; }
        public int ShadowSizeID { get; set; }
        public string Rarity { get; set; }
        public string CheesySaying { get; set; }

        public virtual ShadowSize ShadowSize { get; set; }
        public virtual ICollection<FishTime> FishTimes { get; set; }
    }

    public class FishTime
    {
        public int FishTimeID { get; set; }
        public int FishID { get; set; }
        public int FishLocationID { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }

        public virtual Fish Fish { get; set; }
        public virtual FishLocation FishLocation { get; set; }
    }

    public class FishLocation
    {
        public int FishLocationID { get; set; }
        public string LocationName { get; set; }
    }

    public class ShadowSize
    {
        public int ShadowSizeID { get; set; }
        public string ShadowSizeText { get; set; }
    }

    public class FishContext : DbContext
    {
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<FishTime> FishTimes { get; set; }
        public DbSet<FishLocation> FishLocations { get; set; }
        public DbSet<ShadowSize> ShadowSize { get; set; }
    }
}