using MyRestaurant.Client.Objects;

namespace MyRestaurant.Client.BaseCustomer;

public interface ICustomer
{
    public int GetId();
    public int GetMoneyAmount();

    public void Pay(Order order);

    public bool HasPaid();
}