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

            ShadowSize verySmall = new ShadowSize { ShadowSizeID = 1, ShadowSizeText = "Very Small" };
            ShadowSize small = new ShadowSize { ShadowSizeID = 2, ShadowSizeText = "Small" };
            ShadowSize medium = new ShadowSize { ShadowSizeID = 3, ShadowSizeText = "Medium" };
            ShadowSize large = new ShadowSize { ShadowSizeID = 4, ShadowSizeText = "Large" };
            ShadowSize veryLarge = new ShadowSize { ShadowSizeID = 5, ShadowSizeText = "Very Large" };
            ShadowSize huge = new ShadowSize { ShadowSizeID = 6, ShadowSizeText = "Huge" };
            ShadowSize hugeWithFin = new ShadowSize { ShadowSizeID = 7, ShadowSizeText = "Huge With Fin" };

            FishRarity veryCommon = new FishRarity { FishRarityID = 1, Rarity = "Very Common" };
            FishRarity fairlyCommon = new FishRarity { FishRarityID = 2, Rarity = "Fairly Common" };
            FishRarity common = new FishRarity { FishRarityID = 3, Rarity = "Common" };
            FishRarity uncommon = new FishRarity { FishRarityID = 4, Rarity = "Uncommon" };
            FishRarity rare = new FishRarity { FishRarityID = 5, Rarity = "Rare" };
            FishRarity veryRare = new FishRarity { FishRarityID = 6, Rarity = "Very Rare" };

            FishLocation ocean = new FishLocation { FishLocationID = 1, LocationName = "Ocean" };
            FishLocation river = new FishLocation { FishLocationID = 2, LocationName = "River" };
            FishLocation pond = new FishLocation { FishLocationID = 3, LocationName = "Pond" };
            FishLocation tropicalIsland = new FishLocation { FishLocationID = 4, LocationName = "Tropical Island" };
            FishLocation waterfall = new FishLocation { FishLocationID = 5, LocationName = "Waterfall" };
            FishLocation riverPond = new FishLocation { FishLocationID = 6, LocationName = "River Pond" };
            FishLocation riverMouth = new FishLocation { FishLocationID = 7, LocationName = "River Mouth" };

            context.ShadowSize.AddOrUpdate(
                ss => ss.ShadowSizeID,
                verySmall,
                small,
                medium,
                large,
                veryLarge,
                huge,
                hugeWithFin
            );

            context.FishRarity.AddOrUpdate(
                fr => fr.FishRarityID,
                veryCommon,
				fairlyCommon,
                common,
                uncommon,
                rare,
                veryRare
            );

            context.FishLocations.AddOrUpdate(
                fl => fl.FishLocationID,
                ocean,
                river,
                pond,
                tropicalIsland,
                waterfall,
                riverPond,
                riverMouth
            );

            Fish seaBass = new Fish
            {
                FishID = 1,
                FishName = "Sea Bass",
                Price = 200,
                Rarity = veryCommon,
                ShadowSize = veryLarge,
                CheesySaying = "I caught a sea bass! Oh no, not again!"
            };

            Fish stringfish = new Fish
            {
                FishID = 2,
                FishName = "Stringfish",
                Price = 15000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = "OH MY GOSH! I caught a stringfish! This is AWESOME!"
            };
			
			Fish bitterling = new Fish
            {
                FishID = 3,
                FishName = "Bitterling",
                Price = 900,
                Rarity = fairlyCommon,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish angelfish = new Fish
            {
                FishID = 4,
                FishName = "Angelfish",
                Price = 3000,
                Rarity = rare,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish arapaima = new Fish
            {
                FishID = 5,
                FishName = "Arapaima",
                Price = 10000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish arowana = new Fish
            {
                FishID = 6,
                FishName = "Arowana",
                Price = 10000,
                Rarity = rare,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish barbelSteed = new Fish
            {
                FishID = 7,
                FishName = "Barbel Steed",
                Price = 200,
                Rarity = rare,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish barredKnife = new Fish
            {
                FishID = 8,
                FishName = "Barred Knifejaw",
                Price = 5000,
                Rarity = rare,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish blackBass = new Fish
            {
                FishID = 9,
                FishName = "Black Bass",
                Price = 300,
                Rarity = common,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish blowFish = new Fish
            {
                FishID = 10,
                FishName = "Blow Fish",
                Price = 125,
                Rarity = uncommon,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish blueMarlin = new Fish
            {
                FishID = 11,
                FishName = "Blue Marlin",
                Price = 10000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish bluegill = new Fish
            {
                FishID = 12,
                FishName = "Bluegill",
                Price = 120,
                Rarity = uncommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish butterflyFish = new Fish
            {
                FishID = 13,
                FishName = "Butterfly Fish",
                Price = 1000,
                Rarity = uncommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish carp = new Fish
            {
                FishID = 14,
                FishName = "Carp",
                Price = 300,
                Rarity = fairlyCommon,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
		
			Fish catfish = new Fish
            {
                FishID = 15,
                FishName = "Catfish",
                Price = 800,
                Rarity = fairlyCommon,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish charFish = new Fish
            {
                FishID = 16,
                FishName = "Char",
                Price = 3800,
                Rarity = uncommon,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish cherrySalmon = new Fish
            {
                FishID = 17,
                FishName = "Cherry Salmon",
                Price = 1000,
                Rarity = uncommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish clownfish = new Fish
            {
                FishID = 18,
                FishName = "Clownfish",
                Price = 650,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish coelacanth = new Fish
            {
                FishID = 19,
                FishName = "Coelacanth",
                Price = 15000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish crawfish = new Fish
            {
                FishID = 20,
                FishName = "Crawfish",
                Price = 200,
                Rarity = common,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish crucianCarp = new Fish
            {
                FishID = 21,
                FishName = "Crucian Carp",
                Price = 120,
                Rarity = fairlyCommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish dab = new Fish
            {
                FishID = 22,
                FishName = "Dab",
                Price = 300,
                Rarity = fairlyCommon,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish dace = new Fish
            {
                FishID = 23,
                FishName = "Dace",
                Price = 200,
                Rarity = fairlyCommon,
                ShadowSize = medium,
                CheesySaying = "unknown"
            };
			
			Fish dorado = new Fish
            {
                FishID = 24,
                FishName = "Dorado",
                Price = 15000,
                Rarity = veryRare,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish eel = new Fish
            {
                FishID = 25,
                FishName = "Eel",
                Price = 2000,
                Rarity = fairlyCommon,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish footballFish = new Fish
            {
                FishID = 26,
                FishName = "Football Fish",
                Price = 2500,
                Rarity = uncommon,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish freshwaterGoby = new Fish
            {
                FishID = 27,
                FishName = "Freshwater Goby",
                Price = 300,
                Rarity = rare,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish frog = new Fish
            {
                FishID = 28,
                FishName = "Frog",
                Price = 120,
                Rarity = veryCommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish gar = new Fish
            {
                FishID = 29,
                FishName = "Gar",
                Price = 6000,
                Rarity = rare,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish giantSnakehead = new Fish
            {
                FishID = 30,
                FishName = "Giant Snakehead",
                Price = 5500,
                Rarity = uncommon,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish giantTrrevally = new Fish
            {
                FishID = 31,
                FishName = "Giant Trrevally",
                Price = 4500,
                Rarity = rare,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish goldfish = new Fish
            {
                FishID = 32,
                FishName = "Goldfish",
                Price = 1300,
                Rarity = rare,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish guppy = new Fish
            {
                FishID = 33,
                FishName = "Guppy",
                Price = 1300,
                Rarity = rare,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish hammerhead = new Fish
            {
                FishID = 34,
                FishName = "Hammerhead Shark",
                Price = 8000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish horseMackerel = new Fish
            {
                FishID = 35,
                FishName = "Horse Mackerel",
                Price = 150,
                Rarity = common,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish killifish = new Fish
            {
                FishID = 36,
                FishName = "Killifish",
                Price = 300,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish kingSalmon = new Fish
            {
                FishID = 37,
                FishName = "King Salmon",
                Price = 1800,
                Rarity = uncommon,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish koi = new Fish
            {
                FishID = 38,
                FishName = "Koi",
                Price = 4000,
                Rarity = rare,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish loach = new Fish
            {
                FishID = 39,
                FishName = "Loach",
                Price = 300,
                Rarity = common,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish morayEel = new Fish
            {
                FishID = 40,
                FishName = "Moray Eel",
                Price = 2000,
                Rarity = uncommon,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish napoleonfish = new Fish
            {
                FishID = 41,
                FishName = "Napoleonfish",
                Price = 10000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish neonTetra = new Fish
            {
                FishID = 42,
                FishName = "Neon Tetra",
                Price = 500,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish nibbleFish = new Fish
            {
                FishID = 43,
                FishName = "Nibble Fish",
                Price = 1500,
                Rarity = uncommon,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish oarFish = new Fish
            {
                FishID = 44,
                FishName = "Oar Fish",
                Price = 9000,
                Rarity = veryRare,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish oceanSunfish = new Fish
            {
                FishID = 45,
                FishName = "Ocean Sunfish",
                Price = 4000,
                Rarity = uncommon,
                ShadowSize = huge,
                CheesySaying = "unknown"
            };
			
			Fish oliveFlounder = new Fish
            {
                FishID = 46,
                FishName = "Olive Flounder",
                Price = 800,
                Rarity = uncommon,
                ShadowSize = large,
                CheesySaying = "unknown"
            };
			
			Fish paleChub = new Fish
            {
                FishID = 47,
                FishName = "Pale Chub",
                Price = 200,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = "unknown"
            };
			
			Fish pike = new Fish
            {
                FishID = 48,
                FishName = "Pike",
                Price = 1800,
                Rarity = uncommon,
                ShadowSize = veryLarge,
                CheesySaying = "unknown"
            };
			
			Fish piranha = new Fish
            {
                FishID = 49,
                FishName = "Piranha",
                Price = 2500,
                Rarity = rare,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish pondSmelt = new Fish
            {
                FishID = 50,
                FishName = "Pond Smelt",
                Price = 300,
                Rarity = common,
                ShadowSize = small,
                CheesySaying = "unknown"
            };
			
			Fish popeyedGoldfish = new Fish
            {
                FishID = 51,
                FishName = "Pop-eyed Goldfish",
                Price = 1300,
                Rarity = rare,
                ShadowSize = verySmall,
                CheesySaying = "I got a pop-eyed goldfish! It should have eaten its spinach!"
            };
			
			Fish pufferFish = new Fish
            {
                FishID = 52,
                FishName = "Puffer Fish",
                Price = 240,
                Rarity = uncommon,
                ShadowSize = medium,
                CheesySaying = ""
            };
			
			Fish rainbowTrout = new Fish
            {
                FishID = 53,
                FishName = "Rainbow Trout",
                Price = 800,
                Rarity = fairlyCommon,
                ShadowSize = large,
                CheesySaying = ""
            };
			
			Fish ray = new Fish
            {
                FishID = 54,
                FishName = "Ray",
                Price = 3000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish redSnapper = new Fish
            {
                FishID = 55,
                FishName = "Red Snapper",
                Price = 3000,
                Rarity = uncommon,
                ShadowSize = medium,
                CheesySaying = ""
            };
			
			Fish ribbonEel = new Fish
            {
                FishID = 56,
                FishName = "Ribbon Eel",
                Price = 600,
                Rarity = uncommon,
                ShadowSize = veryLarge,
                CheesySaying = ""
            };
			
			Fish saddledBichir = new Fish
            {
                FishID = 57,
                FishName = "Saddled Bichir",
                Price = 4000,
                Rarity = rare,
                ShadowSize = large,
                CheesySaying = ""
            };
			
			Fish salmon = new Fish
            {
                FishID = 58,
                FishName = "Salmon",
                Price = 700,
                Rarity = common,
                ShadowSize = large,
                CheesySaying = ""
            };
			
			Fish sawShark = new Fish
            {
                FishID = 59,
                FishName = "Saw Shark",
                Price = 12000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish seaButterfly = new Fish
            {
                FishID = 60,
                FishName = "SeaButterfly",
                Price = 1000,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = ""
            };
			
			Fish seahorse = new Fish
            {
                FishID = 61,
                FishName = "Seahorse",
                Price = 1100,
                Rarity = uncommon,
                ShadowSize = verySmall,
                CheesySaying = ""
            };
			
			Fish shanghaiCrab = new Fish
            {
                FishID = 62,
                FishName = "Shanghai Crab",
                Price = 2000,
                Rarity = rare,
                ShadowSize = small,
                CheesySaying = ""
            };
			
			Fish shark = new Fish
            {
                FishID = 63,
                FishName = "Shark",
                Price = 15000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish softshelledTurtle = new Fish
            {
                FishID = 64,
                FishName = "Soft-shelled Turtle",
                Price = 3750,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish squid = new Fish
            {
                FishID = 65,
                FishName = "Squid",
                Price = 400,
                Rarity = uncommon,
                ShadowSize = medium,
                CheesySaying = ""
            };
			
			Fish surgeonFish = new Fish
            {
                FishID = 66,
                FishName = "Surgeon Fish",
                Price = 1000,
                Rarity = uncommon,
                ShadowSize = small,
                CheesySaying = ""
            };
			
			Fish sweetfish = new Fish
            {
                FishID = 67,
                FishName = "Sweetfish",
                Price = 900,
                Rarity = fairlyCommon,
                ShadowSize = medium,
                CheesySaying = ""
            };
			
			Fish tadpole = new Fish
            {
                FishID = 68,
                FishName = "Tadpole",
                Price = 100,
                Rarity = fairlyCommon,
                ShadowSize = verySmall,
                CheesySaying = ""
            };
			
			Fish tuna = new Fish
            {
                FishID = 69,
                FishName = "Tuna",
                Price = 7000,
                Rarity = rare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish whaleShark = new Fish
            {
                FishID = 70,
                FishName = "Whale Shark",
                Price = 13000,
                Rarity = veryRare,
                ShadowSize = huge,
                CheesySaying = ""
            };
			
			Fish yellowPerch = new Fish
            {
                FishID = 71,
                FishName = "Yellow Perch",
                Price = 240,
                Rarity = fairlyCommon,
                ShadowSize = small,
                CheesySaying = ""
            };
			
			Fish zebraTurkeyfish = new Fish
            {
                FishID = 72,
                FishName = "Zebra Turkeyfish",
                Price = 400,
                Rarity = fairlyCommon,
                ShadowSize = medium,
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
                    Fish = seaBass,
                    FishLocation = tropicalIsland,
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
                },
				
				new FishTime
                {
                    Fish = bitterling,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = angelfish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = arapaima,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = arowana,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = barbelSteed,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = barredKnife,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = barredKnife,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = blackBass,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = blowFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = blueMarlin,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = blueMarlin,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = bluegill,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = butterflyFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = carp,
                    FishLocation = riverPond,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = catfish,
                    FishLocation = riverPond,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = charFish,
                    FishLocation = waterfall,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = charFish,
                    FishLocation = waterfall,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = charFish,
                    FishLocation = waterfall,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = cherrySalmon,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = cherrySalmon,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = cherrySalmon,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = clownfish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = clownfish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = coelacanth,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Only when raining or snowing."
                },
				
				new FishTime
                {
                    Fish = crawfish,
                    FishLocation = pond,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = crucianCarp,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = dab,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 10, 1),
                    DateEnd = new DateTime(2000, 4, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = dace,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = dorado,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = eel,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = footballFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = freshwaterGoby,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = frog,
                    FishLocation = pond,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = gar,
                    FishLocation = riverPond,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = giantSnakehead,
                    FishLocation = riverPond,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = giantTrrevally,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 0, 0, 0),
                    AdditionalInformation = "No information at this time."
                },
				
				new FishTime
                {
                    Fish = goldfish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = guppy,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = hammerhead,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = hammerhead,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = horseMackerel,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = horseMackerel,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = killifish,
                    FishLocation = pond,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = kingSalmon,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the River's Mouth."
                },
				
				new FishTime
                {
                    Fish = koi,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = loach,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 5, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = morayEel,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 8, 1),
                    DateEnd = new DateTime(2000, 10, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = morayEel,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = napoleonfish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 8, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = napoleonfish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = neonTetra,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = nibbleFish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 5, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = oarFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 5, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = oceanSunfish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = oceanSunfish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = oliveFlounder,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = oliveFlounder,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = paleChub,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = pike,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = piranha,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = piranha,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = pondSmelt,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = popeyedGoldfish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 9, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 16, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = pufferFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = pufferFish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = rainbowTrout,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = rainbowTrout,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 6, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = rainbowTrout,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = ray,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 8, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 4, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 21, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = ray,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = redSnapper,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = redSnapper,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = ribbonEel,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = saddledBichir,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 21, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 4, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = salmon,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the river's mouth."
                },
				
				new FishTime
                {
                    Fish = sawShark,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = sawShark,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = seaButterfly,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = seahorse,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = seahorse,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = shanghaiCrab,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 9, 15),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = shark,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 6, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = shark,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = softshelledTurtle,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 2, 29),
                    TimeBegin = new DateTime(2000, 1, 1, 16, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 9, 0, 0),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = squid,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 12, 1),
                    DateEnd = new DateTime(2000, 8, 15),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = squid,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = surgeonFish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = surgeonFish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = sweetfish,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 7, 1),
                    DateEnd = new DateTime(2000, 9, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = tadpole,
                    FishLocation = pond,
                    DateBegin = new DateTime(2000, 3, 1),
                    DateEnd = new DateTime(2000, 7, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = tuna,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 11, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = whaleShark,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Has a fin."
                },
				
				new FishTime
                {
                    Fish = yellowPerch,
                    FishLocation = river,
                    DateBegin = new DateTime(2000, 10, 1),
                    DateEnd = new DateTime(2000, 3, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = "Also found at the river's mouth."
                },
				
				new FishTime
                {
                    Fish = zebraTurkeyfish,
                    FishLocation = ocean,
                    DateBegin = new DateTime(2000, 4, 1),
                    DateEnd = new DateTime(2000, 11, 30),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                },
				
				new FishTime
                {
                    Fish = zebraTurkeyfish,
                    FishLocation = tropicalIsland,
                    DateBegin = new DateTime(2000, 1, 1),
                    DateEnd = new DateTime(2000, 12, 31),
                    TimeBegin = new DateTime(2000, 1, 1, 0, 0, 0),
                    TimeEnd = new DateTime(2000, 1, 1, 23, 59, 59),
                    AdditionalInformation = ""
                }
            );
        }
    }
}