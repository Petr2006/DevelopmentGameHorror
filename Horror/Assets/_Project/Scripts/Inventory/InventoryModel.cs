using System;

namespace Game.Inventory
{
    public class InventoryModel : IModel
    {
        public event Action<Item> ItemReceived;

        private ItemData _currentItemData;
        private Item _itemInHand;

        public void Initialize()
        {
            
        }

        public void ReceiveItem(Item item)
        {
            _currentItemData = item.ItemData;
            ItemReceived?.Invoke(item);
        }

        public void SetItemInHand(Item item)
        {
            _itemInHand = item;
        }

        public void CheckItemInHand()
        {

        }
    }
}