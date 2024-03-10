using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Inventory
{
    public class InventoryView : View
    {
        public event Action<Item> ItemInHandChanged;

        [SerializeField] private GameObject _cellsContainer;
        [SerializeField] private Transform _hand;

        private List<Transform> _cells = new List<Transform>();
        private GameObject _currentItem;
        private Cell _selectedCell;
        private int _cellsCount;

        public void Initialize()
        {
            _cellsCount = _cellsContainer.transform.childCount;

            for (int i = 0; i < _cellsCount; i++)
            {
                Transform cell = _cellsContainer.transform.GetChild(i);

                if (cell.TryGetComponent<Cell>(out Cell component))
                    _cells.Add(cell);
            }
        } 

        public void AddItem(Item item)
        {
            foreach (Transform cell in _cells)
            {
                if (cell.TryGetComponent<Cell>(out Cell component) && !component.IsFull)
                {
                    component.Fill(item.ItemData);
                    Destroy(item.gameObject);
                    return;
                }
            }
        }

        public void UseItem()
        {

        }

        private void SelectCell()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SelectCellProcess(0);
            }

            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SelectCellProcess(1);
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SelectCellProcess(2);
            }

            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SelectCellProcess(3);
            }

            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                SelectCellProcess(4);
            }
        }

        private void DropItem()
        {
            if (Input.GetKeyDown(KeyCode.G) && _hand.childCount > 0 && _selectedCell != null)
            {
                _selectedCell.Clear();
                Transform item = _hand.GetChild(0);
                Rigidbody rigidbody = item.GetComponent<Rigidbody>();
                Collider collider = item.GetComponent<Collider>();
                item.parent = null;
                rigidbody.isKinematic = false;
                collider.enabled = true;
                _currentItem = null;
            }
        }

        private void SelectCellProcess(int index)
        {
            foreach (Transform cell in _cells)
            {
                Cell slot = cell.GetComponent<Cell>();

                if (slot.IsSelected)
                {
                    slot.IsSelected = false;

                    if (_currentItem != null)
                        Destroy(_currentItem);
                }
            }

            Cell component = _cells[index].GetComponent<Cell>();
            component.IsSelected = true;
            _selectedCell = component;

            if (_cells[index].childCount > 0)
            {
                _currentItem = Instantiate
                    (component.ItemInCell, _hand.position, _hand.rotation, _hand);
                Rigidbody rigidbody = _currentItem.GetComponent<Rigidbody>();
                Collider collider = _currentItem.GetComponent<Collider>();
                Item item = _currentItem.GetComponent<Item>();
                rigidbody.isKinematic = true;
                collider.enabled = false;
                ItemInHandChanged?.Invoke(item);
            }
        }

        private void Update()
        {
            SelectCell();
            DropItem();
        }
    }
}