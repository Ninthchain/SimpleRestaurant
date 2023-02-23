using System;
using System.Threading.Tasks;

namespace MyRestaurant.Client.Objects.OrderObjects;

public interface IOrderItem
{
    int GetCost();
    string GetName();

    TimeSpan GetMakeTime();
    Task BeginMake();
    bool IsDone();
}