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
            Fish seaBass = new Fish();
            seaBass.FishName = "Sea Bass";
            seaBass.Price = 300;
            seaBass.Rarity = "Very fucking common";
            seaBass.ShadowSize = "Huge, just to troll you.";
            seaBass.CheesySaying = "I caught a sea bass! Oh man, not again!";

            return seaBass;
        }
        public Fish Get()
        {
            Fish seaBass = new Fish();
            seaBass.FishName = "Sea Bass";
            seaBass.Price = 300;
            seaBass.Rarity = "Very fucking common";
            seaBass.ShadowSize = "Huge, just to troll you.";
            seaBass.CheesySaying = "I caught a sea bass! Oh man, not again!";

            return seaBass;
        }

    }
}
