using System;

namespace MyRestaurant.Client;

public class NotEnoughCustomerMoneyException : Exception
{
    public NotEnoughCustomerMoneyException(string message) : base(message)
    {
    }
}