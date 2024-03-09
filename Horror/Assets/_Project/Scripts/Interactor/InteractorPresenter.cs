namespace Game.Interactor
{
    public class InteractorPresenter : IPresenter
    {
        private InteractorModel _model;
        private InteractorView _view;

        public InteractorPresenter(InteractorModel model, InteractorView view)
        {
            _model = model;
            _view = view;

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