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

            Enable();
        }

        public void Enable()
        {
            
        }

        public void Disable()
        {
            
        }
    }
}