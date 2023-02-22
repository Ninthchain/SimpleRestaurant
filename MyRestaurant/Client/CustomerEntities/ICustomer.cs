using MyRestaurant.Client.OrderEntities;
using MyRestaurant.CustomerEntities;

namespace MyRestaurant.Client.CustomerEntities;

public interface ICustomer
{
    public int GetId();
    public int GetMoneyAmount();

    public Order GetOrder();
    public Order CheckoutOrder();
    
    public void ReceiveOrder(Order order);
    public void DoPayOrder();

    public bool HasPaid();

    void SetOrder(Order order);
}