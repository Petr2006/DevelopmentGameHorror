using Game.Interactor;
using Game.Inventory;
using UnityEngine;

namespace Game
{
    public class GameStarter : MonoBehaviour
    {
        [Header("Interactor")]
        [SerializeField] private InteractorView _interactorView;
        private InteractorInitializer _interactorInitializer;

        [Header("Inventory")]
        [SerializeField] private InventoryView _inventoryView;
        private InventoryInitializer _inventoryInitializer;

        private void Awake()
        {
            _interactorInitializer = new InteractorInitializer();
            _interactorInitializer.Initialize(_interactorView);

            _inventoryInitializer = new InventoryInitializer();
            _inventoryInitializer.Initialize(_inventoryView);
            _interactorInitializer.InventoryModelInitialize(_inventoryInitializer.Model);
        }
    }
}