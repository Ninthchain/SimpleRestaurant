using System.Collections.Generic;
using MyRestaurant.CustomerEntities.OrderEntities.Item;

namespace MyRestaurant.Client.OrderEntities
{
    public class Order
    {
        private List<IOrderItem> items;
        
        private bool _isOrdered;
        private bool _isPaid;
        private bool _isDone;
        private int _totalCost;
        private ushort _id;
        
        private void CalculateTotal(ref int total)
        {
            foreach (var item in items)
                total += item.GetCost();
        }
        public Order()
        {
            items = new List<IOrderItem>();
            _isOrdered = false;
            _isPaid = false;
            _totalCost = 0;
        }
        
        
        public async void BeginMakeOrderAsync()
        {
            foreach (var item in items)
                await item.BeginMake();
            
        }

        public void AddItem(IOrderItem item) => items.Add(item);
        public void RemoveItem(IOrderItem item) => items.RemoveAt(items.FindIndex(x => x == item));
        
        public int GetTotal()
        {
            CalculateTotal(ref _totalCost);
            return _totalCost;
        }
        public int GetId() => _id;

        public bool IsPaid() => _isPaid;
    }
}