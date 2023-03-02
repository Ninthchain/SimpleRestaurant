using MyRestaurant.Client.Objects;

namespace MyRestaurant.Client.BaseCustomer;

public interface ICustomer
{
    public int GetId();
    public int GetMoneyAmount();

    public bool HasPaid();
}