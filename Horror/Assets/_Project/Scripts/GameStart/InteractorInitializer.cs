using Game.Interactor;
using Game.Inventory;

namespace Game
{
    public class InteractorInitializer : SystemInitializer<InteractorView>
    {
        private InteractorModel _model;
        private InteractorPresenter _presenter;

        public override void Initialize(InteractorView view)
        {
            _model = new();
            _presenter = new(_model, view);
        }

        public void InventoryModelInitialize(InventoryModel inventoryModel)
        {
            _model.Initialize(inventoryModel);
        }
    }
}