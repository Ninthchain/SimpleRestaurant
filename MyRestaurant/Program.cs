using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MyRestaurant.Client.CustomerSide.CustomerEntities;
using MyRestaurant.Client.OrderEntities;
using MyRestaurant.CustomerEntities.OrderEntities.Item;

namespace MyRestaurant
{
  internal class Program
  {
    public static async Task Main(string[] args)
    {
      ICustomer customer = new Customer(500, 0);
      Order order = new Order(customer);
      for (int i = 0; i < 10; ++i)
      {
        order.GetOrderItems().Add(new OrderItem("Kartoshka", 100, new TimeSpan(0, 0, 3)));
      }
      Debug.Print("Cooking!");
      await order.BeginMakeOrderAsync();
    }
  }
}