using System;

namespace MyRestaurant.Client.OrderEntities;

public class OrderIsEmptyException : Exception
{
    public OrderIsEmptyException(string message) : base(message)
    {
        
    }
}