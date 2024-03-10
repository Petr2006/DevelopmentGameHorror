using System;
using Game.Inventory;

namespace Game.Interactor
{
    public class InteractorModel
    {
        public event Action RayDistanceChanged;

        private InventoryModel _inventoryModel;

        public float RayDistance
        {
            get => _rayDistance;
            set
            {
                if (value > 0)
                {
                    _rayDistance = value;
                    RayDistanceChanged?.Invoke();
                }
            }
        }

        private float _standartRayDistance = 2;
        private float _rayDistance;

        public void Initialize(InventoryModel inventoryModel)
        {
            RayDistance = _standartRayDistance;
            _inventoryModel = inventoryModel;
        }

        public void SendItemToInventory(Item item)
        {
            _inventoryModel.ReceiveItem(item);
        }
    }
}