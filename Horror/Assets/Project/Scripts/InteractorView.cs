using TMPro;
using UnityEngine;

namespace Game.Interactor
{
    public class InteractorView : View
    {
        [SerializeField] private TMP_Text _objectNameText;
        
        private float _rayDistance;
        private Vector2 _screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);

        public void SetRayDistance(float rayDistance)
        {
            _rayDistance = rayDistance;
        }

        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(_screenCenter);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _rayDistance) &&
                hit.collider.TryGetComponent<Interactable>(out Interactable interactable))
            {
                _objectNameText.text = interactable.Name;
            }

            else
                _objectNameText.text = "";
        }
    }
}