using System;
using System.Threading.Tasks;

namespace MyRestaurant.CustomerEntities.OrderEntities.Item;

internal class OrderItem : IOrderItem
{
    private TimeSpan makingTime;
    private int cost;
    private bool isDone;
    private string name;

    public OrderItem(string name, int cost, TimeSpan makeTime)
    {
        makingTime = makeTime;
        isDone = false;
        this.cost = cost;
        this.name = name;
    }

    public virtual int GetCost() => cost;

    public virtual string GetName() => name;
    public TimeSpan GetMakeTime() => makingTime;

    public async Task BeginMake()
    {
        await Task.Delay(makingTime);
        isDone = true;
    }

    public virtual bool IsDone() => isDone;
}