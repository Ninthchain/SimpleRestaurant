using System;
using System.Threading.Tasks;

namespace MyRestaurant.Client.Objects.OrderObjects;

internal class OrderItem : IOrderItem
{
    private TimeSpan _makingTime;
    private int _cost;
    private bool _isDone;
    private string _name;

    public OrderItem(string name, int cost, TimeSpan makeTime)
    {
        _makingTime = makeTime;
        _isDone = false;
        this._cost = cost;
        this._name = name;
    }

    public int GetCost() => _cost;

    public string GetName() => _name;
    public TimeSpan GetMakeTime() => _makingTime;

    public async Task BeginMake()
    {
        await Task.Delay(_makingTime);
        _isDone = true;
    }

    public bool IsDone() => _isDone;
}