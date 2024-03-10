using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "Data/Item")]
    public class ItemData : ScriptableObject
    {
        public string Name => _name;
        public GameObject Prefab => _prefab;
        public GameObject Icon => _icon;

        [SerializeField] private string _name;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _icon;
    }
}
