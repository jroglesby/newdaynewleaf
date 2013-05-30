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
            nlc.Configuration.ProxyCreationEnabled = false;
            var fishes = from f in nlc.Fishes
                         where f.FishName == fishName
                         select f;

            if (fishes.Count() == 0)
                return new Fish();

            Fish seaBass = fishes.First();

            return seaBass;
        }
        public List<Fish> Get()
        {
            NewLeafContext nlc = new NewLeafContext();
            nlc.Configuration.ProxyCreationEnabled = false;

            var fishes = nlc.Fishes.ToList();
            
            return fishes;
        }

    }
}
