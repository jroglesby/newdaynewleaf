namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NewDayNewLeaf.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NewDayNewLeaf.Models.NewLeafContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewDayNewLeaf.Models.NewLeafContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            ShadowSize verySmall = new ShadowSize { ShadowSizeText = "Very Small" };
            ShadowSize small =  new ShadowSize { ShadowSizeText = "Small" };
            ShadowSize medium = new ShadowSize { ShadowSizeText = "Medium" };
            ShadowSize large = new ShadowSize { ShadowSizeText = "Large" };
            ShadowSize veryLarge = new ShadowSize { ShadowSizeText = "Very Large" };
            ShadowSize huge = new ShadowSize { ShadowSizeText = "Huge" };

            FishRarity veryCommon = new FishRarity { Rarity = "Very Common" };
            FishRarity common = new FishRarity { Rarity = "Common" };
            FishRarity uncommon = new FishRarity { Rarity = "Uncommon" };
            FishRarity rare = new FishRarity { Rarity = "Rare" };
            FishRarity veryRare = new FishRarity { Rarity = "Very Rare" };

            FishLocation ocean = new FishLocation { LocationName = "Ocean" };
            FishLocation river = new FishLocation { LocationName = "River" };
            FishLocation pond = new FishLocation { LocationName = "Pond" };
            FishLocation tropicalIsland = new FishLocation { LocationName = "Tropical Island" };
            FishLocation waterfall = new FishLocation {LocationName = "Waterfall" };
            FishLocation riverPond = new FishLocation {LocationName = "River Pond" };

            context.ShadowSize.AddOrUpdate(
                ss => ss.ShadowSizeText,
                verySmall,
                small,
                medium,
                large,
                veryLarge,
                huge
            );

            context.FishRarity.AddOrUpdate(
                fr => fr.Rarity,
                veryCommon,
                common,
                uncommon,
                rare,
                veryRare
            );

            context.FishLocations.AddOrUpdate(
                fl => fl.LocationName,
                ocean,
                river,
                pond,
                tropicalIsland,
                waterfall,
                riverPond
            );

            Fish seaBass = new Fish
            {
                FishName = "Sea Bass",
                Price = 300,
                Rarity = veryCommon,
                ShadowSize = veryLarge,
                CheesySaying = "I caught a sea bass! Oh no, not again!"
            };

            Fish stringfish = new Fish
            {
                FishName = "Stringfish",
                Price = 15000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = "OH MY GOSH! I caught a stringfish! This is AWESOME!"
            };

            context.Fishes.AddOrUpdate(
                f => f.FishName,
                seaBass,
                stringfish
            );

            context.FishTimes.AddOrUpdate(
                new FishTime
                {
                    Fish = seaBass,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
                new FishTime
                {
                    Fish = stringfish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                }
            );
        }
    }
}
