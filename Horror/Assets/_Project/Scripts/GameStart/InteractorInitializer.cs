using Game.Interactor;

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
            _model.Initialize();
        }
    }
}