using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewDayNewLeaf.Models;

namespace NewDayNewLeaf.Controllers
{
    public class EditFishController : Controller
    {
        //
        // GET: /EditFish/

        public ActionResult Index(int? fish)
        {
            NewLeafContext nlc = new NewLeafContext();
            if (fish.HasValue)
            {
                Fish editFish = nlc.Fishes.Include("ShadowSize").Include("Rarity").Where(x => x.FishID == (int)fish).FirstOrDefault();

                SelectList shadow;
                SelectList rarity;
                if (editFish != null)
                {
                    ViewData["FishID"] = editFish.FishID;
                    shadow = new SelectList(nlc.ShadowSize, "ShadowSizeID", "ShadowSizeText", editFish.ShadowSizeID);
                    rarity = new SelectList(nlc.FishRarity, "FishRarityID", "Rarity", editFish.FishRarityID);
                    ViewData["FishName"] = editFish.FishName;
                    ViewData["Price"] = editFish.Price;
                    ViewData["Saying"] = editFish.CheesySaying;
                }
                else
                {
                    shadow = new SelectList(nlc.ShadowSize, "ShadowSizeID", "ShadowSizeText");
                    rarity = new SelectList(nlc.FishRarity, "FishRarityID", "Rarity");
                }
                ViewData["Shadow"] = shadow;
                ViewData["Rarity"] = rarity;
            }
            else
            {
                ViewData["Shadow"] = new SelectList(nlc.ShadowSize, "ShadowSizeID", "ShadowSizeText");
                ViewData["Rarity"] = new SelectList(nlc.FishRarity, "FishRarityID", "Rarity");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Save(int? FishID, string FishName, int price, int shadow, int rarity, string saying)
        {
            NewLeafContext nlc = new NewLeafContext();
            Fish fish = new Fish();
            if (FishID.HasValue)
            {
                fish.FishID = (int)FishID;
                fish = nlc.Fishes.Where(x => x.FishID == fish.FishID).FirstOrDefault();
            }
            else
            {
                fish.FishID = nlc.Fishes.Max(x => x.FishID) + 1;
                nlc.Fishes.Add(fish);
            }

            fish.FishName = FishName;
            fish.Price = price;
            fish.ShadowSizeID = shadow;
            fish.FishRarityID = rarity;
            fish.CheesySaying = saying;

            nlc.SaveChanges();

            return View();
        }

    }
}
