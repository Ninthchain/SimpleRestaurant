using MyRestaurant.Client.OrderEntities;

namespace MyRestaurant.Client.CustomerSide.CustomerEntities;

public interface ICustomer
{
    public int GetId();
    public int GetMoneyAmount();
    
    public void Pay(Order order);

    public bool HasPaid();
}