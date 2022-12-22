using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private RaycastProvider _raycastProvider;

    private Transform _hover;
    private Transform _selection;

    public event Action<Transform> OnHoverChanged = delegate { };
    public event Action<Transform> OnSelectionChanged = delegate { };

    private void Update()
    {
        var selection = _raycastProvider.GetSelection();

        UpdateHover(selection);
        UpdateSelection(selection);
    }

    private void UpdateHover(Transform selection)
    {
        if (_hover == selection || Input.GetMouseButton(0)) return;

        OnHoverChanged(selection);
        _hover = selection;
    }

    private void UpdateSelection(Transform selection)
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnSelectionChanged(selection);
            _selection = selection;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            OnSelectionChanged(null);
            _selection = null;
        }
    }
}