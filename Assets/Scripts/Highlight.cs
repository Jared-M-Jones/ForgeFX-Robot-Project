using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : SelectionManager
{
    [SerializeField] public Color _highlightColor = Color.red;
    [SerializeField] public Color _defaultColor = Color.white;

    //private void Update()
    //{
    //    if (_currentSelection != null) OnDeselect(_currentSelection);
        
    //    Check(CreateRay());
    //    _currentSelection = GetSelection();

    //    if (_currentSelection != null) OnSelect(_currentSelection);
    //}

    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material.color = _highlightColor;
        }
    }

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material.color = _defaultColor;
        }
    }
}
