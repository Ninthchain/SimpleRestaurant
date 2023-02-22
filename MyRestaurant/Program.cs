using System;
using MyRestaurant.Client;
using MyRestaurant.Client.CustomerEntities;
using MyRestaurant.Client.OrderEntities;
using MyRestaurant.CustomerEntities.OrderEntities.Item;

namespace MyRestaurant
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ICustomer customer = new Customer(500, 0);
      Order order = new Order();
      for (int i = 0; i < 10; ++i)
      {
        order.AddItem(new OrderItem("Kartoshka", 100, new TimeSpan(0, 0, 10)));
      }
      
      customer.SetOrder(order);
      try
      {
        customer.DoPayOrder();
      }
      catch (NotEnoughCustomerMoneyException ex)
      {
        Console.WriteLine("Not enough money");
      }
    }
  }
}