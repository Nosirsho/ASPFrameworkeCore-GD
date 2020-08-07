using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.mocks {
    public class MockCars : IAllCars {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car { 
                        name = "Tesla Model 5", 
                        shortDesc = "Быстрый автомобиль", 
                        longDesc = "Крассный, быстрый и очень тихий автомобиль", 
                        img = "/img/tesla.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Ford.png",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "BMV M3",
                        shortDesc = "Спортивный",
                        longDesc = "Быстрый, черный и крассивый",
                        img = "/img/BMV.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mersedes C class",
                        shortDesc = "Уютный",
                        longDesc = "Уютный и большой",
                        img = "/img/Mersedes.jpg",
                        price = 40000,
                        isFavorite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный",
                        longDesc = "Бесшумный и удобный",
                        img = "/img/Nissan.jpg",
                        price = 14000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
