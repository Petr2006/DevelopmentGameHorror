using Game.Inventory;

namespace Game
{
    public class InventoryInitializer : SystemInitializer<InventoryView>
    {
        public InventoryModel Model => _model;

        private InventoryModel _model;
        private InventoryPresenter _presenter;

        public override void Initialize(InventoryView view)
        {
            _model = new();
            _presenter = new(view, _model);
            _model.Initialize();
        }
    }
}