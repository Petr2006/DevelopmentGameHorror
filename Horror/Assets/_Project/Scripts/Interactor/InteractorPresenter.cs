using Game.Inventory;

namespace Game.Interactor
{
    public class InteractorPresenter : IPresenter
    {
        private InteractorModel _model;
        private InteractorView _view;

        public InteractorPresenter
            (InteractorModel model, InteractorView view)
        {
            _model = model;
            _view = view;

            Enable();
        }

        public void Enable()
        {
            _model.RayDistanceChanged += UpdateRayDistance;
            _view.ItemPickedUp += SendItemToModel;
        }

        public void Disable()
        {
            _model.RayDistanceChanged -= UpdateRayDistance;
            _view.ItemPickedUp -= SendItemToModel;
        }

        private void UpdateRayDistance()
        {
            _view.SetRayDistance(_model.RayDistance);
        }

        private void SendItemToModel(Item item)
        {
            _model.SendItemToInventory(item);
        }
    }
}