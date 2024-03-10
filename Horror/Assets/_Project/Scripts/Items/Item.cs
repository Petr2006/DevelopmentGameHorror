using UnityEngine;

namespace Game
{
    [RequireComponent(typeof (Rigidbody))]
    public class Item : MonoBehaviour
    {
        public ItemData ItemData => _itemData;

        [SerializeField] private ItemData _itemData;
    }
}