using System;

namespace Game.Interactor
{
    public class InteractorModel : IModel
    {
        public event Action RayDistanceChanged;

        public float RayDistance
        {
            get => _rayDistance;
            set
            {
                if (value > 0)
                {
                    _rayDistance = value;
                    RayDistanceChanged?.Invoke();
                }
            }
        }

        private float _standartRayDistance = 2;
        private float _rayDistance;

        public void Initialize()
        {
            RayDistance = _standartRayDistance;
        }
    }
}