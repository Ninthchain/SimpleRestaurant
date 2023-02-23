using System;
using System.Threading.Tasks;

namespace MyRestaurant.Client.Objects.OrderObjects;

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

    public int GetCost() => cost;

    public string GetName() => name;
    public TimeSpan GetMakeTime() => makingTime;

    public async Task BeginMake()
    {
        await Task.Delay(makingTime);
        isDone = true;
    }

    public bool IsDone() => isDone;
}