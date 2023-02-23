using System;

namespace MyRestaurant.Client;

public class NotEnoughMoneyException : Exception
{
    public NotEnoughMoneyException(string message) : base(message)
    {
    }
}