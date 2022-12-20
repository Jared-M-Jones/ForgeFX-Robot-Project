using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;

    //private HighlightSelectionResponse _highlight;

    [SerializeField] private Color _highlightColor = Color.red;
    [SerializeField] private Color _defaultColor = Color.white;

    private Transform _currentSelection;
    private Transform _selection;

    private void Update()
    {
        if (_currentSelection != null) OnDeselect(_currentSelection);

        Check(CreateRay());
        _currentSelection = GetSelection();

        if (_currentSelection != null) OnSelect(_currentSelection);
    }

    public void Check(Ray ray)
    {
        _selection = null;
        if (Physics.Raycast(ray, out var hit, _layer))
        {
            var selection = hit.transform;
            _selection = selection;

            Debug.DrawRay(ray.origin, ray.direction);
            Debug.Log(hit.collider, hit.collider);
        }
    }

    public static Ray CreateRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    public Transform GetSelection()
    {
        return _selection;
    }

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