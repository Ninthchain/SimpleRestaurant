using System.Collections;
using System.Collections.Generic;
using MyRestaurant.Client.BaseCustomer;

namespace MyRestaurant.Client.Objects;

public class Register
{
    private Queue<ICustomer> _queue;
    private int _queueSize;
    private int _slotAmount;

    public Register(int slotAmount)
    {
        
    }
}