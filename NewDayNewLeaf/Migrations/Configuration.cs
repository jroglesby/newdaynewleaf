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
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            // to avoid creating duplicate seed data. E.g.
            //
            // context.People.AddOrUpdate(
            // p => p.FullName,
            // new Person { FullName = "Andrew Peters" },
            // new Person { FullName = "Brice Lambson" },
            // new Person { FullName = "Rowan Miller" }
            // );
            //

            ShadowSize verySmall = new ShadowSize { ShadowSizeText = "Very Small" };
            ShadowSize small = new ShadowSize { ShadowSizeText = "Small" };
            ShadowSize medium = new ShadowSize { ShadowSizeText = "Medium" };
            ShadowSize large = new ShadowSize { ShadowSizeText = "Large" };
            ShadowSize veryLarge = new ShadowSize { ShadowSizeText = "Very Large" };
            ShadowSize huge = new ShadowSize { ShadowSizeText = "Huge" };
            ShadowSize hugeWithFin = new ShadowSize { ShadowSizeText = "Huge With Fin" };

            FishRarity veryCommon = new FishRarity { Rarity = "Very Common" };
            FishRarity fairlyCommon = new FishRarity { Rarity = "Fairly Common" };
            FishRarity common = new FishRarity { Rarity = "Common" };
            FishRarity uncommon = new FishRarity { Rarity = "Uncommon" };
            FishRarity rare = new FishRarity { Rarity = "Rare" };
            FishRarity veryRare = new FishRarity { Rarity = "Very Rare" };

            FishLocation ocean = new FishLocation { LocationName = "Ocean" };
            FishLocation river = new FishLocation { LocationName = "River" };
            FishLocation pond = new FishLocation { LocationName = "Pond" };
            FishLocation tropicalIsland = new FishLocation { LocationName = "Tropical Island" };
            FishLocation waterfall = new FishLocation { LocationName = "Waterfall" };
            FishLocation riverPond = new FishLocation { LocationName = "River Pond" };
            FishLocation riverMouth = new FishLocation { LocationName = "River Mouth" };

            context.ShadowSize.AddOrUpdate(
                ss => ss.ShadowSizeText,
                verySmall,
                small,
                medium,
                large,
                veryLarge,
                huge,
                hugeWithFin
            );

            context.SaveChanges();

            context.FishRarity.AddOrUpdate(
                fr => fr.Rarity,
                veryCommon,
                fairlyCommon,
                common,
                uncommon,
                rare,
                veryRare
            );

            context.SaveChanges();

            context.FishLocations.AddOrUpdate(
                fl => fl.LocationName,
                ocean,
                river,
                pond,
                tropicalIsland,
                waterfall,
                riverPond,
                riverMouth
            );

            context.SaveChanges();

            Fish seaBass = new Fish
            {
                FishName = "Sea Bass",
                Price = 200,
                FishRarityID = veryCommon.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "I caught a sea bass! Oh no, not again!"
            };

            Fish stringfish = new Fish
            {
                FishName = "Stringfish",
                Price = 15000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "OH MY GOSH! I caught a stringfish! This is AWESOME!"
            };
			
			Fish bitterling = new Fish
            {
                FishName = "Bitterling",
                Price = 900,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish angelfish = new Fish
            {
                FishName = "Angelfish",
                Price = 3000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish arapaima = new Fish
            {
                FishName = "Arapaima",
                Price = 10000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish arowana = new Fish
            {
                FishName = "Arowana",
                Price = 10000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish barbelSteed = new Fish
            {
                FishName = "Barbel Steed",
                Price = 200,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish barredKnife = new Fish
            {
                FishName = "Barred Knifejaw",
                Price = 5000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish blackBass = new Fish
            {
                FishName = "Black Bass",
                Price = 300,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish blowFish = new Fish
            {
                FishName = "Blow Fish",
                Price = 125,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish blueMarlin = new Fish
            {
                FishName = "Blue Marlin",
                Price = 10000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish bluegill = new Fish
            {
                FishName = "Bluegill",
                Price = 120,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish butterflyFish = new Fish
            {
                FishName = "Butterfly Fish",
                Price = 1000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish carp = new Fish
            {
                FishName = "Carp",
                Price = 300,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
		
			Fish catfish = new Fish
            {
                FishName = "Catfish",
                Price = 800,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish charFish = new Fish
            {
                FishName = "Char",
                Price = 3800,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish cherrySalmon = new Fish
            {
                FishName = "Cherry Salmon",
                Price = 1000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish clownfish = new Fish
            {
                FishName = "Clownfish",
                Price = 650,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish coelacanth = new Fish
            {
                FishName = "Coelacanth",
                Price = 15000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish crawfish = new Fish
            {
                FishName = "Crawfish",
                Price = 200,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish crucianCarp = new Fish
            {
                FishName = "Crucian Carp",
                Price = 120,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish dab = new Fish
            {
                FishName = "Dab",
                Price = 300,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish dace = new Fish
            {
                FishName = "Dace",
                Price = 200,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish dorado = new Fish
            {
                FishName = "Dorado",
                Price = 15000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish eel = new Fish
            {
                FishName = "Eel",
                Price = 2000,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish footballFish = new Fish
            {
                FishName = "Football Fish",
                Price = 2500,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish freshwaterGoby = new Fish
            {
                FishName = "Freshwater Goby",
                Price = 300,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish frog = new Fish
            {
                FishName = "Frog",
                Price = 120,
                FishRarityID = veryCommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish gar = new Fish
            {
                FishName = "Gar",
                Price = 6000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish giantSnakehead = new Fish
            {
                FishName = "Giant Snakehead",
                Price = 5500,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish giantTrrevally = new Fish
            {
                FishName = "Giant Trrevally",
                Price = 4500,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish goldfish = new Fish
            {
                FishName = "Goldfish",
                Price = 1300,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish guppy = new Fish
            {
                FishName = "Guppy",
                Price = 1300,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish hammerhead = new Fish
            {
                FishName = "Hammerhead Shark",
                Price = 8000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =hugeWithFin.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish horseMackerel = new Fish
            {
                FishName = "Horse Mackerel",
                Price = 150,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish killifish = new Fish
            {
                FishName = "Killifish",
                Price = 300,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish kingSalmon = new Fish
            {
                FishName = "King Salmon",
                Price = 1800,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish koi = new Fish
            {
                FishName = "Koi",
                Price = 4000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish loach = new Fish
            {
                FishName = "Loach",
                Price = 300,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish morayEel = new Fish
            {
                FishName = "Moray Eel",
                Price = 2000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish napoleonfish = new Fish
            {
                FishName = "Napoleonfish",
                Price = 10000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish neonTetra = new Fish
            {
                FishName = "Neon Tetra",
                Price = 500,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish nibbleFish = new Fish
            {
                FishName = "Nibble Fish",
                Price = 1500,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish oarFish = new Fish
            {
                FishName = "Oar Fish",
                Price = 9000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish oceanSunfish = new Fish
            {
                FishName = "Ocean Sunfish",
                Price = 4000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =hugeWithFin.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish oliveFlounder = new Fish
            {
                FishName = "Olive Flounder",
                Price = 800,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish paleChub = new Fish
            {
                FishName = "Pale Chub",
                Price = 200,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish pike = new Fish
            {
                FishName = "Pike",
                Price = 1800,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish piranha = new Fish
            {
                FishName = "Piranha",
                Price = 2500,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish pondSmelt = new Fish
            {
                FishName = "Pond Smelt",
                Price = 300,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = "unknown"
            };
			
			Fish popeyedGoldfish = new Fish
            {
                FishName = "Pop-eyed Goldfish",
                Price = 1300,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = "I got a pop-eyed goldfish! It should have eaten its spinach!"
            };
			
			Fish pufferFish = new Fish
            {
                FishName = "Puffer Fish",
                Price = 240,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish rainbowTrout = new Fish
            {
                FishName = "Rainbow Trout",
                Price = 800,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish ray = new Fish
            {
                FishName = "Ray",
                Price = 3000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish redSnapper = new Fish
            {
                FishName = "Red Snapper",
                Price = 3000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish ribbonEel = new Fish
            {
                FishName = "Ribbon Eel",
                Price = 600,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =veryLarge.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish saddledBichir = new Fish
            {
                FishName = "Saddled Bichir",
                Price = 4000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish salmon = new Fish
            {
                FishName = "Salmon",
                Price = 700,
                FishRarityID = common.FishRarityID,
                ShadowSizeID =large.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish sawShark = new Fish
            {
                FishName = "Saw Shark",
                Price = 12000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =hugeWithFin.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish seaButterfly = new Fish
            {
                FishName = "SeaButterfly",
                Price = 1000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish seahorse = new Fish
            {
                FishName = "Seahorse",
                Price = 1100,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish shanghaiCrab = new Fish
            {
                FishName = "Shanghai Crab",
                Price = 2000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish shark = new Fish
            {
                FishName = "Shark",
                Price = 15000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =hugeWithFin.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish softshelledTurtle = new Fish
            {
                FishName = "Soft-shelled Turtle",
                Price = 3750,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish squid = new Fish
            {
                FishName = "Squid",
                Price = 400,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish surgeonFish = new Fish
            {
                FishName = "Surgeon Fish",
                Price = 1000,
                FishRarityID = uncommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish sweetfish = new Fish
            {
                FishName = "Sweetfish",
                Price = 900,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish tadpole = new Fish
            {
                FishName = "Tadpole",
                Price = 100,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =verySmall.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish tuna = new Fish
            {
                FishName = "Tuna",
                Price = 7000,
                FishRarityID = rare.FishRarityID,
                ShadowSizeID =huge.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish whaleShark = new Fish
            {
                FishName = "Whale Shark",
                Price = 13000,
                FishRarityID = veryRare.FishRarityID,
                ShadowSizeID =hugeWithFin.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish yellowPerch = new Fish
            {
                FishName = "Yellow Perch",
                Price = 240,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =small.ShadowSizeID,
                CheesySaying = ""
            };
			
			Fish zebraTurkeyfish = new Fish
            {
                FishName = "Zebra Turkeyfish",
                Price = 400,
                FishRarityID = fairlyCommon.FishRarityID,
                ShadowSizeID =medium.ShadowSizeID,
                CheesySaying = ""
            };

            context.Fishes.AddOrUpdate(
                f => f.FishName,
                seaBass,
                stringfish,
                bitterling,
                angelfish,
                arapaima,
                arowana,
                barbelSteed,
                barredKnife,
                blackBass,
                blowFish,
                blueMarlin,
                bluegill,
                butterflyFish,
                carp,
                catfish,
                charFish,
                cherrySalmon,
                clownfish,
                coelacanth,
                crawfish,
                crucianCarp,
                dab,
                dace,
                dorado,
                eel,
                footballFish,
                freshwaterGoby,
                frog,
                gar,
                giantSnakehead,
                giantTrrevally,
                goldfish,
                guppy,
                hammerhead,
                horseMackerel,
                killifish,
                kingSalmon,
                koi,
                loach,
                morayEel,
                napoleonfish,
                neonTetra,
                nibbleFish,
                oarFish,
                oceanSunfish,
                oliveFlounder,
                paleChub,
                pike,
                piranha,
                pondSmelt,
                popeyedGoldfish,
                pufferFish,
                rainbowTrout,
                ray,
                redSnapper,
                ribbonEel,
                saddledBichir,
                salmon,
                sawShark,
                seaButterfly,
                seahorse,
                shanghaiCrab,
                shark,
                softshelledTurtle,
                squid,
                surgeonFish,
                sweetfish,
                tadpole,
                tuna,
                whaleShark,
                yellowPerch,
                zebraTurkeyfish
            );

            context.SaveChanges();

            context.FishTimes.AddOrUpdate(
                ft => new { ft.FishID, ft.DateBegin, ft.DateEnd, ft.TimeBegin, ft.TimeEnd, ft.FishLocationID},
                new FishTime
                {
                    FishID = seaBass.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = seaBass.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = stringfish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = bitterling.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = angelfish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = arapaima.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = arowana.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = barbelSteed.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = barredKnife.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = barredKnife.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = blackBass.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = blowFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = blueMarlin.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = blueMarlin.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = bluegill.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = butterflyFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = carp.FishID,
                    FishLocationID =riverPond.FishLocationID,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = catfish.FishID,
                    FishLocationID =riverPond.FishLocationID,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = charFish.FishID,
                    FishLocationID =waterfall.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = charFish.FishID,
                    FishLocationID =waterfall.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = charFish.FishID,
                    FishLocationID =waterfall.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = cherrySalmon.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = cherrySalmon.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = cherrySalmon.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = clownfish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = clownfish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = coelacanth.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Only when raining or snowing."
                },
				
                new FishTime
                {
                    FishID = crawfish.FishID,
                    FishLocationID =pond.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = crucianCarp.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = dab.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 10, 1),
                    DateEnd = new DateTime(2000, 4, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = dace.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = dorado.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = eel.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = footballFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = freshwaterGoby.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = frog.FishID,
                    FishLocationID =pond.FishLocationID,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = gar.FishID,
                    FishLocationID =riverPond.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = giantSnakehead.FishID,
                    FishLocationID =riverPond.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = giantTrrevally.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 0, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = goldfish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = guppy.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = hammerhead.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = hammerhead.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = horseMackerel.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = horseMackerel.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = killifish.FishID,
                    FishLocationID =pond.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = kingSalmon.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the River's Mouth."
                },
				
                new FishTime
                {
                    FishID = koi.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = loach.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 5, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = morayEel.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 8, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = morayEel.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = napoleonfish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = napoleonfish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = neonTetra.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = nibbleFish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = oarFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 5, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = oceanSunfish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = oceanSunfish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = oliveFlounder.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = oliveFlounder.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = paleChub.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = pike.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = piranha.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = piranha.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = pondSmelt.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = popeyedGoldfish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = pufferFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = pufferFish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = rainbowTrout.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = rainbowTrout.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = rainbowTrout.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = ray.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 8, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = ray.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = redSnapper.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = redSnapper.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = ribbonEel.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = saddledBichir.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = salmon.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the river.FishLocationID's mouth."
                },
				
                new FishTime
                {
                    FishID = sawShark.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = sawShark.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = seaButterfly.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = seahorse.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = seahorse.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = shanghaiCrab.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 9, 15),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = shark.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = shark.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = softshelledTurtle.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = squid.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 8, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = squid.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = surgeonFish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = surgeonFish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = sweetfish.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = tadpole.FishID,
                    FishLocationID =pond.FishLocationID,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 7, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = tuna.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = whaleShark.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
                new FishTime
                {
                    FishID = yellowPerch.FishID,
                    FishLocationID =river.FishLocationID,
                    DateBegin = new DateTime(2000, 10, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the river.FishLocationID's mouth."
                },
				
                new FishTime
                {
                    FishID = zebraTurkeyfish.FishID,
                    FishLocationID =ocean.FishLocationID,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
                new FishTime
                {
                    FishID = zebraTurkeyfish.FishID,
                    FishLocationID =tropicalIsland.FishLocationID,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                }
            );
            context.SaveChanges();
        }
    }
}