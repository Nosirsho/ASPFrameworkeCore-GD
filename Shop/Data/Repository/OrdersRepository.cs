using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class OrdersRepository : IAllOrders {

        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart) {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order) {
            order.orderTime = DateTime.Now; // Устанавлиеваем время заказа = настоящее время
            appDBContent.Order.Add(order); // Добавить заказ в табл. Order
            appDBContent.SaveChanges();

            var items = shopCart.listShopItems; //Получает все товары выбранного ползователем с корзины(shopCart.listShopItems)


            foreach (var el in items){
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.id,
                    orderId = order.id,
                    price = el.car.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
