namespace MyRestaurant.CustomerEntities.OrderEntities.Item;

internal class OrderItem : IOrderItem
{
    private uint cost;
    private string name;

    public OrderItem(uint cost, string name)
    {
        this.cost = cost;
        this.name = name;
    }

    public uint GetItemCost() => cost;
    
    public string GetItemName() => name;
}