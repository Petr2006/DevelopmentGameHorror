using UnityEngine;

namespace Game.Inventory
{
    public class InventoryPresenter : IPresenter
    {
        private InventoryView _view;
        private InventoryModel _model;

        public InventoryPresenter(InventoryView view, InventoryModel model)
        {
            _view = view;
            _model = model;
            
            view.Initialize();
            Enable();
        }

        public void Enable()
        {
            _model.ItemReceived += SendItemToView;
            _view.ItemInHandChanged += UpdateItemInHand;
        }

        public void Disable()
        {
            _model.ItemReceived -= SendItemToView;
            _view.ItemInHandChanged -= UpdateItemInHand;
        }

        private void SendItemToView(Item item)
        {
            _view.AddItem(item);
        }

        private void UpdateItemInHand(Item item)
        {
            _model.SetItemInHand(item);
        }
    }
}