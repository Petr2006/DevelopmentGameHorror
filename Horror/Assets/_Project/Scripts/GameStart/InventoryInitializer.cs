using Game.Inventory;

namespace Game
{
    public class InventoryInitializer : SystemInitializer<InventoryView>
    {
        private InventoryModel _model;
        private InventoryPresenter _presenter;

        public override void Initialize(InventoryView view)
        {
            _model = new();
            _presenter = new(view, _model);
        }
    }
}