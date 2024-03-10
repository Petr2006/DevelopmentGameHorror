using System;
using TMPro;
using UnityEngine;

namespace Game.Interactor
{
    public class InteractorView : View
    {
        public event Action<Item> ItemPickedUp;

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
                hit.collider.TryGetComponent<Item>(out Item item))
            {
                _objectNameText.text = item.ItemData.Name;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    ItemPickedUp?.Invoke(item);
                }
            }

            else
                _objectNameText.text = "";
        }
    }
}