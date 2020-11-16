using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class representing the menu
    /// </summary>
    public static class Menu 
    {
        
        /// <summary>
        /// A method yield returns each entree on the menu
        /// </summary>
        /// <returns>yeild returns each entree on the menu</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();
            
        } 
        /// <summary>
        /// A method yield returns each side with every side
        /// </summary>
        /// <returns>returns each side with each size</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf1.Size = Enums.Size.Small;
            dwf2.Size = Enums.Size.Medium;
            dwf3.Size = Enums.Size.Large;
            yield return dwf1;
            yield return dwf2;
            yield return dwf3;
            FriedMiraak fm1 = new FriedMiraak();
            FriedMiraak fm2 = new FriedMiraak();
            FriedMiraak fm3 = new FriedMiraak();
            fm1.Size = Enums.Size.Small;
            fm2.Size = Enums.Size.Medium;
            fm3.Size = Enums.Size.Large;
            yield return fm1;
            yield return fm2;
            yield return fm3;
            MadOtarGrits mog1 = new MadOtarGrits();
            MadOtarGrits mog2 = new MadOtarGrits();
            MadOtarGrits mog3 = new MadOtarGrits();
            mog1.Size = Enums.Size.Small;
            mog2.Size = Enums.Size.Medium;
            mog3.Size = Enums.Size.Large;
            yield return mog1;
            yield return mog2;
            yield return mog3;
            VokunSalad vs1 = new VokunSalad();
            VokunSalad vs2 = new VokunSalad();
            VokunSalad vs3 = new VokunSalad();
            vs1.Size = Enums.Size.Small;
            vs2.Size = Enums.Size.Medium;
            vs3.Size = Enums.Size.Large;
            yield return vs1;
            yield return vs2;
            yield return vs3;
        }
        /// <summary>
        /// A method returning every possible drink on the menu
        /// </summary>
        /// <returns>yield returns each drink on menu</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            ArentinoAppleJuice aj1 = new ArentinoAppleJuice();
            ArentinoAppleJuice aj2 = new ArentinoAppleJuice();
            ArentinoAppleJuice aj3 = new ArentinoAppleJuice();
            aj1.Size = Enums.Size.Small;
            aj2.Size = Enums.Size.Medium;
            aj3.Size = Enums.Size.Large;
            yield return aj1;
            yield return aj2;
            yield return aj3;
            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc1.Size = Enums.Size.Small;
            cc2.Size = Enums.Size.Medium;
            cc3.Size = Enums.Size.Large;
            yield return cc1;
            yield return cc2;
            yield return cc3;
            MarkarthMilk mm1 = new MarkarthMilk();
            MarkarthMilk mm2 = new MarkarthMilk();
            MarkarthMilk mm3 = new MarkarthMilk();
            mm1.Size = Enums.Size.Small;
            mm2.Size = Enums.Size.Medium;
            mm3.Size = Enums.Size.Large;
            yield return mm1;
            yield return mm2;
            yield return mm3;
            WarriorWater ww1 = new WarriorWater();
            WarriorWater ww2 = new WarriorWater();
            WarriorWater ww3 = new WarriorWater();
            ww1.Size = Enums.Size.Small;
            ww2.Size = Enums.Size.Medium;
            ww3.Size = Enums.Size.Large;
            yield return ww1;
            yield return ww2;
            yield return ww3;
            SailorSoda ssb1 = new SailorSoda();
            SailorSoda ssb2 = new SailorSoda();
            SailorSoda ssb3 = new SailorSoda();
            ssb1.Size = Enums.Size.Small;
            ssb2.Size = Enums.Size.Medium;
            ssb3.Size = Enums.Size.Large;
            ssb1.Flavor = Enums.SodaFlavor.Blackberry;
            ssb2.Flavor = Enums.SodaFlavor.Blackberry;
            ssb3.Flavor = Enums.SodaFlavor.Blackberry;
            yield return ssb1;
            yield return ssb2;
            yield return ssb3;
            SailorSoda ssc1 = new SailorSoda();
            SailorSoda ssc2 = new SailorSoda();
            SailorSoda ssc3 = new SailorSoda();
            ssc1.Size = Enums.Size.Small;
            ssc2.Size = Enums.Size.Medium;
            ssc3.Size = Enums.Size.Large;
            ssc1.Flavor = Enums.SodaFlavor.Cherry;
            ssc2.Flavor = Enums.SodaFlavor.Cherry;
            ssc3.Flavor = Enums.SodaFlavor.Cherry;
            yield return ssc1;
            yield return ssc2;
            yield return ssc3;
            SailorSoda ssg1 = new SailorSoda();
            SailorSoda ssg2 = new SailorSoda();
            SailorSoda ssg3 = new SailorSoda();
            ssg1.Size = Enums.Size.Small;
            ssg2.Size = Enums.Size.Medium;
            ssg3.Size = Enums.Size.Large;
            ssg1.Flavor = Enums.SodaFlavor.Grapefruit;
            ssg2.Flavor = Enums.SodaFlavor.Grapefruit;
            ssg3.Flavor = Enums.SodaFlavor.Grapefruit;
            yield return ssg1;
            yield return ssg2;
            yield return ssg3;
            SailorSoda ssl1 = new SailorSoda();
            SailorSoda ssl2 = new SailorSoda();
            SailorSoda ssl3 = new SailorSoda();
            ssl1.Size = Enums.Size.Small;
            ssl2.Size = Enums.Size.Medium;
            ssl3.Size = Enums.Size.Large;
            ssl1.Flavor = Enums.SodaFlavor.Lemon;
            ssl2.Flavor = Enums.SodaFlavor.Lemon;
            ssl3.Flavor = Enums.SodaFlavor.Lemon;
            yield return ssl1;
            yield return ssl2;
            yield return ssl3;
            SailorSoda ssp1 = new SailorSoda();
            SailorSoda ssp2 = new SailorSoda();
            SailorSoda ssp3 = new SailorSoda();
            ssp1.Size = Enums.Size.Small;
            ssp2.Size = Enums.Size.Medium;
            ssp3.Size = Enums.Size.Large;
            ssp1.Flavor = Enums.SodaFlavor.Peach;
            ssp2.Flavor = Enums.SodaFlavor.Peach;
            ssp3.Flavor = Enums.SodaFlavor.Peach;
            yield return ssp1;
            yield return ssp2;
            yield return ssp3;
            SailorSoda ssw1 = new SailorSoda();
            SailorSoda ssw2 = new SailorSoda();
            SailorSoda ssw3 = new SailorSoda();
            ssw1.Size = Enums.Size.Small;
            ssw2.Size = Enums.Size.Medium;
            ssw3.Size = Enums.Size.Large;
            ssw1.Flavor = Enums.SodaFlavor.Watermelon;
            ssw2.Flavor = Enums.SodaFlavor.Watermelon;
            ssw3.Flavor = Enums.SodaFlavor.Watermelon;
            yield return ssw1;
            yield return ssw2;
            yield return ssw3;
        }
        /// <summary>
        /// represents every item on the menu
        /// </summary>
        /// <returns>yield returns every item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();
            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf1.Size = Enums.Size.Small;
            dwf2.Size = Enums.Size.Medium;
            dwf3.Size = Enums.Size.Large;
            yield return dwf1;
            yield return dwf2;
            yield return dwf3;
            FriedMiraak fm1 = new FriedMiraak();
            FriedMiraak fm2 = new FriedMiraak();
            FriedMiraak fm3 = new FriedMiraak();
            fm1.Size = Enums.Size.Small;
            fm2.Size = Enums.Size.Medium;
            fm3.Size = Enums.Size.Large;
            yield return fm1;
            yield return fm2;
            yield return fm3;
            MadOtarGrits mog1 = new MadOtarGrits();
            MadOtarGrits mog2 = new MadOtarGrits();
            MadOtarGrits mog3 = new MadOtarGrits();
            mog1.Size = Enums.Size.Small;
            mog2.Size = Enums.Size.Medium;
            mog3.Size = Enums.Size.Large;
            yield return mog1;
            yield return mog2;
            yield return mog3;
            VokunSalad vs1 = new VokunSalad();
            VokunSalad vs2 = new VokunSalad();
            VokunSalad vs3 = new VokunSalad();
            vs1.Size = Enums.Size.Small;
            vs2.Size = Enums.Size.Medium;
            vs3.Size = Enums.Size.Large;
            yield return vs1;
            yield return vs2;
            yield return vs3;
            ArentinoAppleJuice aj1 = new ArentinoAppleJuice();
            ArentinoAppleJuice aj2 = new ArentinoAppleJuice();
            ArentinoAppleJuice aj3 = new ArentinoAppleJuice();
            aj1.Size = Enums.Size.Small;
            aj2.Size = Enums.Size.Medium;
            aj3.Size = Enums.Size.Large;
            yield return aj1;
            yield return aj2;
            yield return aj3;
            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc1.Size = Enums.Size.Small;
            cc2.Size = Enums.Size.Medium;
            cc3.Size = Enums.Size.Large;
            yield return cc1;
            yield return cc2;
            yield return cc3;
            MarkarthMilk mm1 = new MarkarthMilk();
            MarkarthMilk mm2 = new MarkarthMilk();
            MarkarthMilk mm3 = new MarkarthMilk();
            mm1.Size = Enums.Size.Small;
            mm2.Size = Enums.Size.Medium;
            mm3.Size = Enums.Size.Large;
            yield return mm1;
            yield return mm2;
            yield return mm3;
            WarriorWater ww1 = new WarriorWater();
            WarriorWater ww2 = new WarriorWater();
            WarriorWater ww3 = new WarriorWater();
            ww1.Size = Enums.Size.Small;
            ww2.Size = Enums.Size.Medium;
            ww3.Size = Enums.Size.Large;
            yield return ww1;
            yield return ww2;
            yield return ww3;
            SailorSoda ssb1 = new SailorSoda();
            SailorSoda ssb2 = new SailorSoda();
            SailorSoda ssb3 = new SailorSoda();
            ssb1.Size = Enums.Size.Small;
            ssb2.Size = Enums.Size.Medium;
            ssb3.Size = Enums.Size.Large;
            ssb1.Flavor = Enums.SodaFlavor.Blackberry;
            ssb2.Flavor = Enums.SodaFlavor.Blackberry;
            ssb3.Flavor = Enums.SodaFlavor.Blackberry;
            yield return ssb1;
            yield return ssb2;
            yield return ssb3;
            SailorSoda ssc1 = new SailorSoda();
            SailorSoda ssc2 = new SailorSoda();
            SailorSoda ssc3 = new SailorSoda();
            ssc1.Size = Enums.Size.Small;
            ssc2.Size = Enums.Size.Medium;
            ssc3.Size = Enums.Size.Large;
            ssc1.Flavor = Enums.SodaFlavor.Cherry;
            ssc2.Flavor = Enums.SodaFlavor.Cherry;
            ssc3.Flavor = Enums.SodaFlavor.Cherry;
            yield return ssc1;
            yield return ssc2;
            yield return ssc3;
            SailorSoda ssg1 = new SailorSoda();
            SailorSoda ssg2 = new SailorSoda();
            SailorSoda ssg3 = new SailorSoda();
            ssg1.Size = Enums.Size.Small;
            ssg2.Size = Enums.Size.Medium;
            ssg3.Size = Enums.Size.Large;
            ssg1.Flavor = Enums.SodaFlavor.Grapefruit;
            ssg2.Flavor = Enums.SodaFlavor.Grapefruit;
            ssg3.Flavor = Enums.SodaFlavor.Grapefruit;
            yield return ssg1;
            yield return ssg2;
            yield return ssg3;
            SailorSoda ssl1 = new SailorSoda();
            SailorSoda ssl2 = new SailorSoda();
            SailorSoda ssl3 = new SailorSoda();
            ssl1.Size = Enums.Size.Small;
            ssl2.Size = Enums.Size.Medium;
            ssl3.Size = Enums.Size.Large;
            ssl1.Flavor = Enums.SodaFlavor.Lemon;
            ssl2.Flavor = Enums.SodaFlavor.Lemon;
            ssl3.Flavor = Enums.SodaFlavor.Lemon;
            yield return ssl1;
            yield return ssl2;
            yield return ssl3;
            SailorSoda ssp1 = new SailorSoda();
            SailorSoda ssp2 = new SailorSoda();
            SailorSoda ssp3 = new SailorSoda();
            ssp1.Size = Enums.Size.Small;
            ssp2.Size = Enums.Size.Medium;
            ssp3.Size = Enums.Size.Large;
            ssp1.Flavor = Enums.SodaFlavor.Peach;
            ssp2.Flavor = Enums.SodaFlavor.Peach;
            ssp3.Flavor = Enums.SodaFlavor.Peach;
            yield return ssp1;
            yield return ssp2;
            yield return ssp3;
            SailorSoda ssw1 = new SailorSoda();
            SailorSoda ssw2 = new SailorSoda();
            SailorSoda ssw3 = new SailorSoda();
            ssw1.Size = Enums.Size.Small;
            ssw2.Size = Enums.Size.Medium;
            ssw3.Size = Enums.Size.Large;
            ssw1.Flavor = Enums.SodaFlavor.Watermelon;
            ssw2.Flavor = Enums.SodaFlavor.Watermelon;
            ssw3.Flavor = Enums.SodaFlavor.Watermelon;
            yield return ssw1;
            yield return ssw2;
            yield return ssw3;
        }
        /// <summary>
        /// Searches the movies in the database for matches
        /// </summary>
        /// <param name="terms">the terms to search for</param>
        /// <returns>The results of the search</returns>

        public static IEnumerable<IOrderItem> Search(string terms)
        {
            IEnumerable<IOrderItem> results = FullMenu();
            
            //null check
            if (terms == null)
            {
                return results;
            }
            /*foreach (IOrderItem item in FullMenu())
            {
                // Add the movie if the title is a match
                if (item.ToString().Length != 0 && (item.ToString()).Contains(terms))
                {
                    results.Add(item);
                }
            }*/
            string[] t = terms.Split(' ');
            //for(int i = 0; i < t.Length; i++)
            //{
            
                results = results.Where(item => item.ToString() != null && t.Any( val =>  item.ToString().Contains(val) || item.Description.Contains(val)));
           
                
            //}
            
            return results;
            
        }

        /// <summary>
        /// Gets the possible FoodType
        /// </summary>
        public static string[] FoodType
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks",
            };
        }

        public static IEnumerable<IOrderItem> FilterByFoodType(IEnumerable<IOrderItem> items, IEnumerable<string> foodT)
        {
            // TODO: Filter the list
            // If no filter is specified, just return the provided collection
            /*if (foodT == null || foodT.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            IEnumerable<IOrderItem> ent = Menu.Entrees();
            IEnumerable<IOrderItem> sid = Menu.Sides();
            IEnumerable<IOrderItem> dri = Menu.Drinks();
            foreach (IOrderItem item in items)
            {
                if (foodT.Contains("Entrees"))
                {
                    foreach (IOrderItem temp in ent)
                    {
                        if (temp.ToString().Equals(item.ToString()))
                        {
                            results.Add(item);
                        }

                    }

                }
                else if(foodT.Contains("Sides"))
                {
                    foreach(IOrderItem temp in sid)
                    {
                        if(temp.ToString().Equals(item.ToString()))
                        {
                            results.Add(item);
                        }
                        
                    }
                }
                else if(foodT.Contains("Drinks"))
                {
                    foreach (IOrderItem temp in dri)
                    {
                        if (temp.ToString().Equals(item.ToString()))
                        {
                            results.Add(item);
                        }

                    }
                }
            } */
            IEnumerable<IOrderItem> results = items;
            if (foodT != null && foodT.Count() != 0)
            {
                results = results.Where(item => (item is Drink && foodT.Contains("Drinks")) || (item is Entree && foodT.Contains("Entrees")) || (item is Side && foodT.Contains("Sides")));
            }
                return results;
        }
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            /*
            // TODO: Filter movies
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            } */
            IEnumerable<IOrderItem> results = items;
            if(min != null && max != null)
            {
                results = results.Where(item => item.Price < max && item.Price > min);
            }
            else if(min != null)
            {
                results = results.Where(item => item.Price > min);
            }    
            else if(max != null)
            {
                results = results.Where(item => item.Price < max);
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            /*// TODO: Filter movies
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }*/
            IEnumerable<IOrderItem> results = items;
            if (min != null && max != null)
            {
                results = results.Where(item => item.Calories < max && item.Calories > min);
            }
            else if (min != null)
            {
                results = results.Where(item => item.Calories > min);
            }
            else if (max != null)
            {
                results = results.Where(item => item.Calories < max);
            }

            return results;
        }
    }

    
}
