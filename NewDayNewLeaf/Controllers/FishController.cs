﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewDayNewLeaf.Models;
using System.Web.Http;

namespace NewDayNewLeaf.Controllers
{
    public class FishController : ApiController
    {
        //
        // GET: /Fish/

        public FishVM Get(string fishName)
        {
            NewLeafContext nlc = new NewLeafContext();
            Fish seaBass = nlc.Fishes.Include("FishTimes").Include("ShadowSize").Include("Rarity").Include("FishTimes.FishLocation").FirstOrDefault(f => f.FishName == fishName);
            
            return seaBass;
        }
        public List<FishVM> Get()
        {
            NewLeafContext nlc = new NewLeafContext();
            nlc.Configuration.ProxyCreationEnabled = false;
            var fishes = nlc.Fishes.Include("FishTimes").Include("ShadowSize").Include("FishTimes.FishLocation").Include("Rarity").ToList();
            List<FishVM> fishList = new List<FishVM>();
            foreach (Fish fish in fishes)
            {
                fishList.Add(fish);
            }
            return fishList;
        }
        public List<FishVM> GetCurrentFish(long ticks, string includeTropical = "N")
        {
            NewLeafContext nlc = new NewLeafContext();
            nlc.Configuration.ProxyCreationEnabled = false;

            DateTime currentDate = new DateTime(ticks);

            List<FishVM> fishes = new List<FishVM>();

            DateTime datePart = new DateTime(2000, currentDate.Month, currentDate.Day);

            DateTime timePart = new DateTime(2000, 1, 1, currentDate.Hour, currentDate.Minute, currentDate.Second);

            List<FishTime> fishTimes;

            if (includeTropical == "N")
            {
                fishTimes = nlc.FishTimes.Include("Fish").Include("FishLocation").Include("Fish.Rarity").Include("Fish.ShadowSize")
                .Where(ft => ft.FishLocation.LocationName != "Tropical Island" && (
                    ( ft.DateBegin < ft.DateEnd && ( ft.DateBegin <= datePart && ft.DateEnd >= datePart ) && (
                        ( ft.TimeBegin < ft.TimeEnd && ( ft.TimeBegin <= timePart && ft.TimeEnd > timePart ) ) || 
                        ( ft.TimeBegin > ft.TimeEnd && ( ft.TimeBegin <= timePart || ft.TimeEnd > timePart ) )
                    ) ) || 
                    ( ft.DateBegin > ft.DateEnd && ( ft.DateBegin <= datePart || ft.DateEnd >= datePart ) && (
                        ( ft.TimeBegin < ft.TimeEnd && ( ft.TimeBegin <= timePart && ft.TimeEnd > timePart ) ) || 
                        ( ft.TimeBegin > ft.TimeEnd && ( ft.TimeBegin <= timePart || ft.TimeEnd > timePart ) )
                    ) )
                )).OrderBy(ft => ft.Fish.FishName).ToList();
            }
            else
            {
                fishTimes = nlc.FishTimes.Include("Fish").Include("FishLocation")
                .Where(ft => ft.FishLocation.LocationName == "Tropical Island" && ((ft.DateBegin < ft.DateEnd && ft.DateBegin <= datePart && ft.DateEnd >= datePart && ((ft.TimeBegin < ft.TimeEnd && (ft.TimeBegin <= timePart && ft.TimeEnd > timePart)) || (ft.TimeBegin > ft.TimeEnd && (ft.TimeBegin <= timePart || ft.TimeEnd > timePart)))) || (ft.DateBegin > ft.DateEnd && ft.DateBegin <= datePart || ft.DateEnd >= datePart && ((ft.TimeBegin < ft.TimeEnd && (ft.TimeBegin <= timePart && ft.TimeEnd > timePart)) || (ft.TimeBegin > ft.TimeEnd && (ft.TimeBegin <= timePart || ft.TimeEnd > timePart)))))).OrderBy(ft => ft.Fish.FishName).ToList();
            }

            foreach (FishTime ft in fishTimes)
            {
                if (!fishes.Any(f => f.FishName == ft.Fish.FishName))
                {
                    var fish = ft.Fish;
                    //fish.FishTimes.Add(ft);
                    fishes.Add(fish);
                }
            }

            return fishes;
        }

    }
}
