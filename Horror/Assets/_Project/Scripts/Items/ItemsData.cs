using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "Data/Item")]
    public class ItemsData : ScriptableObject
    {
        public string Name => _name;

        [SerializeField] private string _name;
    }
}
