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
            NewLeafContext fc = new NewLeafContext();
            fc.Configuration.ProxyCreationEnabled = false;
            var fishes = from f in fc.Fishes
                         where f.FishName == "Sea Bass"
                         select f;

            Fish seaBass = fishes.First();

            return seaBass;
        }
        public Fish Get()
        {
            NewLeafContext fc = new NewLeafContext();

            var ShadowSize = new ShadowSize
            {
                ShadowSizeText = "Huge"
            };

            fc.ShadowSize.Add(ShadowSize);
            fc.SaveChanges();

            var fish = new Fish
            {
                FishName = "Sea Bass",
                Price = 300,
                Rarity = "Very common",
                CheesySaying = "Oh no, not again!",
                ShadowSizeID = fc.ShadowSize.Single(ss => ss.ShadowSizeText == "Huge").ShadowSizeID
            };

            fc.Fishes.Add(fish);
            fc.SaveChanges();

            return fish;
        }

    }
}
