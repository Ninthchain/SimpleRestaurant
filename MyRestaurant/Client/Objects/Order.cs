using System.Collections.Generic;
using System.Threading.Tasks;
using MyRestaurant.Client.BaseCustomer;
using MyRestaurant.Client.CustomerSide;
using MyRestaurant.Client.Objects.OrderObjects;
using MyRestaurant.Client.OrderEntities;


namespace MyRestaurant.Client.Objects
{
    public class Order
    {
        private ICustomer _customer;

        private int _totalPrice;
        
        private List<IOrderItem> _items;
        
        private bool _isPaid;
        private bool _isDone;

        private uint _id;

        private OrderStatus _currentStatus;
        
        public Order(ICustomer customer)
        {
            _items = new List<IOrderItem>();
            _isPaid = false;
            _isDone = false;
            _totalPrice = 0;
            
            _customer = customer;
        }

        public void SetId(uint value) => _id = value;
        
        public void Done() => _isDone = true;
        
        public ICustomer GetCustomer() => _customer;
        
        public async Task BeginMakeOrderAsync()
        {
            foreach (var item in _items)
                await item.BeginMake();
        }

        public List<IOrderItem> GetOrderItems() => _items;
        public uint GetId() => _id;

        public bool IsPaid() => _isPaid;
        public bool IsDone() => _isDone;

        public int GetTotal()
        {
            if (_totalPrice <= 0) 
                throw new OrderIsEmptyException("The order is empty");
            
            return _totalPrice;
        }
    }
}