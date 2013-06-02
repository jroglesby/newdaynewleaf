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

    }
}
