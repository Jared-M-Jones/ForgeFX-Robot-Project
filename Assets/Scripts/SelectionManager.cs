using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private RaycastProvider _raycastProvider;

    private Transform _currentSelection;

    public event Action<Transform> OnHoverChanged = delegate { };
    public event Action<Transform> OnSelectionChanged = delegate { };

    private void Update()
    {
        var Selection = _raycastProvider.GetSelection();

        if(_currentSelection != Selection)
        {
            OnHoverChanged(Selection);
            _currentSelection = Selection;
        }

        if (Input.GetMouseButtonDown(0))
        {
            OnSelectionChanged(Selection);
            _currentSelection = Selection;
        }
        //if (_currentSelection != Selection && Input.GetMouseButtonUp(0))
        //{
        //    _currentSelection = null;
        //}
    }
}