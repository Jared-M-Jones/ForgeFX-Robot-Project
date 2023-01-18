using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabManager : MonoBehaviour
{
    [SerializeField] private SelectionManager _selectionManager;

    private IGrabbable _grabSelection;

    private void OnEnable()
    {
        _selectionManager.OnSelectionChanged += OnSelectionChanged;
    }

    private void OnDisable()
    {
        _selectionManager.OnSelectionChanged -= OnSelectionChanged;
    }

    private void OnSelectionChanged(Transform obj)
    {
        _grabSelection?.OnDropObject();
        if (obj && obj.TryGetComponent(out _grabSelection))
        {
            _grabSelection.OnGrabObject(obj);
        }
    }
}
