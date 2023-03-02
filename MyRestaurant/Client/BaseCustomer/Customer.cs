using System;
using MyRestaurant.Client.BaseCustomer;
using MyRestaurant.Client.Objects;
using MyRestaurant.Client.OrderEntities;

namespace MyRestaurant.Client.CustomerSide.CustomerEntities
{
    public class Customer : IDisposable, ICustomer
    {
        private uint _id;

        private int _moneyAmount;

        private bool _hasPaid;
        private bool _disposed;
        

        public Customer(int moneyAmount, uint id)
        {
            _hasPaid = false;
            _disposed = false;
            _moneyAmount = moneyAmount;
            _id = id;
        }

        public void Dispose()
        {
            using (this)
            {
                _moneyAmount = 0;
                _disposed = true;
            }
        }

        public int GetId() => Convert.ToInt32(_id);

        public int GetMoneyAmount() => _moneyAmount;

        public bool HasPaid() => _hasPaid;
    }


}