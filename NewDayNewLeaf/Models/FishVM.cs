using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewDayNewLeaf.Models
{
    public class FishVM
    {
        public string FishName { get; set; }
        public int Price { get; set; }
        public string ShadowSize { get; set; }
        public string Rarity { get; set; }
        public string CheesySaying { get; set; }

        public List<FishTimeVM> FishTimes { get; set; }

        public static implicit operator FishVM(Fish f)
        {
            FishVM fvm = new FishVM {    
                FishName = f.FishName,
                Price = f.Price,
                ShadowSize = f.ShadowSize.ShadowSizeText,
                Rarity = f.Rarity.Rarity,
                CheesySaying = f.CheesySaying
            };

            fvm.FishTimes = new List<FishTimeVM>();

            foreach (FishTimeVM ftvm in f.FishTimes)
            {
                fvm.FishTimes.Add(ftvm);
            }

            return fvm;
        }
    }

    public class FishTimeVM
    {
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public string AdditionalInformation { get; set; }
        public string LocationName { get; set; }

        public static implicit operator FishTimeVM(FishTime ft)
        {
            FishTimeVM ftvm = new FishTimeVM
            {
                DateBegin = ft.DateBegin,
                DateEnd = ft.DateEnd,
                TimeBegin = ft.TimeBegin,
                TimeEnd = ft.TimeEnd,
                AdditionalInformation = ft.AdditionalInformation,
                LocationName = ft.FishLocation.LocationName
            };

            return ftvm;
        }
    }
}