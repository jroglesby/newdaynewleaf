using System;
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

        public Fish Get(string fishName)
        {
            NewLeafContext nlc = new NewLeafContext();
            Fish seaBass = nlc.Fishes.Include("FishTimes").Include("ShadowSize").Include("Rarity").Include("FishTimes.FishLocation").FirstOrDefault(f => f.FishName == fishName);
            
            return seaBass;
        }
        public List<Fish> Get()
        {
            NewLeafContext nlc = new NewLeafContext();
            nlc.Configuration.ProxyCreationEnabled = false;
            var fishes = nlc.Fishes.Include("FishTimes").Include("ShadowSize").Include("FishTimes.FishLocation").Include("Rarity").ToList();
            return fishes;
        }
        public List<Fish> GetCurrentFish(long ticks)
        {
            NewLeafContext nlc = new NewLeafContext();
            nlc.Configuration.ProxyCreationEnabled = false;

            DateTime currentDate = new DateTime(ticks);

            List<Fish> fishes = new List<Fish>();

            DateTime datePart = new DateTime(2000, currentDate.Month, currentDate.Day);

            DateTime timePart = new DateTime(2000, 1, 1, currentDate.Hour, currentDate.Minute, currentDate.Second);

            var fishTimes = nlc.FishTimes.Include("Fish").Include("Fish.Rarity").Include("Fish.ShadowSize").Include("FishLocation").Where(ft => ft.DateBegin <= datePart && ft.DateEnd >= datePart && ft.TimeBegin <= timePart && ft.TimeEnd >= timePart).ToList();

            foreach (FishTime ft in fishTimes)
            {
                fishes.Add(ft.Fish);
            }

            return fishes;
        }

    }
}
