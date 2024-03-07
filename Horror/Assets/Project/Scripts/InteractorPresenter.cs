namespace Game.Interactor
{
    public class InteractorPresenter : IPresenter
    {
        private InteractorModel _model;
        private InteractorView _view;

        public InteractorPresenter(InteractorModel interactorModel, InteractorView interactorView)
        {
            _model = interactorModel;
            _view = interactorView;

            Enable();
        }

        public void Enable()
        {
            _model.RayDistanceChanged += UpdateRayDistance;
        }

        public void Disable()
        {
            _model.RayDistanceChanged -= UpdateRayDistance;
        }

        private void UpdateRayDistance()
        {
            _view.SetRayDistance(_model.RayDistance);
        }
    }
}