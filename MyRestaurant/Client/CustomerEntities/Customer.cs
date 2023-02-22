using System;
using MyRestaurant.Client.OrderEntities;

namespace MyRestaurant.Client.CustomerEntities
{
    public class Customer : IDisposable, ICustomer
    {
        private int _moneyAmount;

        private uint _id;

        private bool _hasReceived;
        private bool _hasPaid;
        private bool _disposed;

        private Order _order;

        public Customer(int moneyAmount, uint id)
        {
            
            _hasReceived = false;
            _hasPaid = false;
            _order = null;
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
        public Order GetOrder() => _order;

        public void SetOrder(Order order) => _order = order;
        public void ReceiveOrder(Order order)
        {
            _order = order;
            _hasReceived = true;
        }

        public void DoPayOrder()
        {
            if (_order is null)
                throw new NullReferenceException("The order is null");
            if (_moneyAmount - _order.GetTotal() < 0)
                throw new NotEnoughCustomerMoneyException("");
            
            _moneyAmount -= _order.GetTotal();
            _hasPaid = true;
        }

        public bool HasPaid() => _hasPaid;
        public bool HasRecievedOrder() => _hasReceived;
        public void GetOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order CheckoutOrder()
        {
            return new Order();
        }
    }


}