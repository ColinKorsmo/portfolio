using Microsoft.EntityFrameworkCore;

namespace final_project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, FinalProjectDbContext context)
        {
            if (context.Items.Any())
            {
                return;
            }

            var spirit = new Aspect { Name = "Spirit" };
            var vitality = new Aspect { Name = "Vitality" };
            var weapon = new Aspect { Name = "Weapon" };

            context.Aspects.AddRange(spirit, vitality, weapon);
            context.SaveChanges(); 

            var spiritItems = new List<Item>
            {
                new Item { Name = "Mystic Reach", Aspect = spirit, Price = 500M },
                new Item { Name = "Suppressor", Aspect = spirit, Price = 1250M },
                new Item { Name = "Rapid Recharge", Aspect = spirit, Price = 3500M },
                new Item { Name = "Extra Charge", Aspect = spirit, Price = 500M },
                new Item { Name = "Mystic Burst", Aspect = spirit, Price = 500M },
                new Item { Name = "Bullet Resist Shredder", Aspect = spirit, Price = 1250M },
                new Item { Name = "Mystic Vulnerability", Aspect = spirit, Price = 1250M },
                new Item { Name = "Quicksilver Reload", Aspect = spirit, Price = 500M },
                new Item { Name = "Suppressor", Aspect = spirit, Price = 1250M },
                new Item { Name = "Mystic Slow", Aspect = spirit, Price = 3000M },
                new Item { Name = "Knockdown", Aspect = spirit, Price = 3000M },
                new Item { Name = "Diviner's Kevlar", Aspect = spirit, Price = 6200M }
            };

            var vitalityItems = new List<Item>
            {
                new Item { Name = "Sprint Boots", Aspect = vitality, Price = 500M },
                new Item { Name = "Debuff Reducer", Aspect = vitality, Price = 1250M },
                new Item { Name = "Leech", Aspect = vitality, Price = 6200M },
                new Item { Name = "Extra Health", Aspect = vitality, Price = 500M },
                new Item { Name = "Enduring Spirit", Aspect = vitality, Price = 500M },
                new Item { Name = "Bullet Armor", Aspect = vitality, Price = 1250M },
                new Item { Name = "Enduring Speed", Aspect = vitality, Price = 1250M },
                new Item { Name = "Bullet Lifesteal", Aspect = vitality, Price = 1250M },
                new Item { Name = "Fortitude", Aspect = vitality, Price = 3000M },
                new Item { Name = "Return Fire", Aspect = vitality, Price = 1250M },
                new Item { Name = "Metal Skin", Aspect = vitality, Price = 3000M },
                new Item { Name = "Rescue Beam", Aspect = vitality, Price = 3000M }
            };

            var weaponItems = new List<Item>
            {
                new Item { Name = "Melee Charge", Aspect = weapon, Price = 1250M },
                new Item { Name = "Intensifying Magazine", Aspect = weapon, Price = 3000M },
                new Item { Name = "Mystic Shot", Aspect = weapon, Price = 500M },
                new Item { Name = "Hollow Point Ward", Aspect = weapon, Price = 500M },
                new Item { Name = "Restorative Shot", Aspect = weapon, Price = 500M },
                new Item { Name = "Long Range", Aspect = weapon, Price = 1250M },
                new Item { Name = "Kinetic Dash", Aspect = weapon, Price = 1250M },
                new Item { Name = "Swift Striker", Aspect = weapon, Price = 1250M },
                new Item { Name = "Burst Fire", Aspect = weapon, Price = 3000M },
                new Item { Name = "Pristine Emblem", Aspect = weapon, Price = 3000M },
                new Item { Name = "Tesla Bullets", Aspect = weapon, Price = 3000M },
                new Item { Name = "Silencer", Aspect = weapon, Price = 6200M }
            };

            context.Items.AddRange(spiritItems.Concat(vitalityItems).Concat(weaponItems));
            context.SaveChanges(); 
        }
    }
}
