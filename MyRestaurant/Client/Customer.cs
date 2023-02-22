using System;
using MyRestaurant.CustomerEntities;

namespace MyRestaurant
{
    public class Customer : IDisposable
    {
        private bool disposed;
        private int _moneyAmount;
        private Order order;

        public Customer(int moneyAmount)
        {
            disposed = false;
            _moneyAmount = moneyAmount;
        }

        public void Dispose()
        {
            using (this)
            {
                _moneyAmount = 0;
                disposed = true;
            }
        }
    }
}