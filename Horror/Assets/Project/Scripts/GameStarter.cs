using Game.Interactor;
using UnityEngine;

namespace Game
{
    public class GameStarter : MonoBehaviour
    {
        [Header("Interactor")]

        [SerializeField] private InteractorView _interactorView;
        private InteractorModel _interactorModel;
        private InteractorPresenter _interactorPresenter;

        private void Awake()
        {
            InteractorInit();
        }

        private void InteractorInit()
        {
            _interactorModel = new();
            _interactorPresenter = new(_interactorModel, _interactorView);
            _interactorModel.Initialize();
        }
    }
}