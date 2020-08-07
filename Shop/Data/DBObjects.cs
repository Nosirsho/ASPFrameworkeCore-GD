using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class DBObjects {
        public static void initial(AppDBContent content) {
            
                

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value ));

            if (!content.Car.Any()) {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model 5",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Крассный, быстрый и очень тихий автомобиль",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Ford.png",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "BMV M3",
                        shortDesc = "Спортивный",
                        longDesc = "Быстрый, черный и крассивый",
                        img = "/img/BMV.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "Mersedes C class",
                        shortDesc = "Уютный",
                        longDesc = "Уютный и большой",
                        img = "/img/Mersedes.jpg",
                        price = 40000,
                        isFavorite = false,
                        available = false,
                        Category = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный",
                        longDesc = "Бесшумный и удобный",
                        img = "/img/Nissan.jpg",
                        price = 14000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                );

            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классический", desc = "Машины с двигателем внктреннего згарания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
