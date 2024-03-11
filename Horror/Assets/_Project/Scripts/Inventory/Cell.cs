using Game;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool IsFull { get => _isFull; set => _isFull = value; }
    public bool IsSelected 
    { 
        get => _isSelected;
        set 
        { 
            _isSelected = value; 

            if (_isSelected)
                transform.localScale = new Vector3(1.25f, 1.25f, 1);

            else
                transform.localScale = new Vector3(1, 1, 1);
        } 
    }
    public GameObject ItemInCell => _itemInCell;
    public GameObject IconInCell => _iconInCell;

    private bool _isFull = false;
    private bool _isSelected = false;
    private GameObject _itemInCell;
    private GameObject _iconInCell;
    private GameObject _iconInstantiate;

    public void Fill(ItemData itemData)
    {
        _isFull = true;
        _itemInCell = itemData.Prefab;
        _iconInCell = itemData.Icon;
        _iconInstantiate = Instantiate(_iconInCell, transform);
    }

    public void Clear()
    {
        _isFull = false;
        Destroy(_iconInstantiate);
        _iconInstantiate = null;
        _itemInCell = null;
        _iconInCell = null;
    }
}
