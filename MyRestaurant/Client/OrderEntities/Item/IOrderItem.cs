using System;
using System.Threading.Tasks;

namespace MyRestaurant.CustomerEntities.OrderEntities.Item
{
    public interface IOrderItem
    {
        int GetCost();
        string GetName();

        TimeSpan GetMakeTime();
        Task BeginMake();
        bool IsDone();
    }
}