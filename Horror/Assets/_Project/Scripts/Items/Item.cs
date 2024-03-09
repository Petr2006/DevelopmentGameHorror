using UnityEngine;

namespace Game
{
    public class Item : MonoBehaviour
    {
        public ItemsData ItemData => _itemData;

        [SerializeField] private ItemsData _itemData;
    }
}