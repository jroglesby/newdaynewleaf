using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace NewDayNewLeaf.Models
{

    public class Fish
    {
        public int FishID { get; set; }
        public string FishName { get; set; }
        public int Price { get; set; }
        public string CheesySaying { get; set; }
        public string BlathersInfo { get; set; }

        public FishRarity Rarity { get; set; }
        public ShadowSize ShadowSize { get; set; }
        public ICollection<FishTime> FishTimes { get; set; }
    }

    public class FishTime
    {
        public int FishTimeID { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public string AdditionalInformation { get; set; }

        
        public Fish Fish { get; set; }
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

    public class FishRarity
    {
        public int FishRarityID { get; set; }
        public string Rarity { get; set; }
    }
}