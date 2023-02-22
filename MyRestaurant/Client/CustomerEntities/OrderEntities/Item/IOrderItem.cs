namespace MyRestaurant.CustomerEntities.OrderEntities.Item
{
    internal interface IOrderItem
    {
        uint GetItemCost();
        string GetItemName();
    }
}