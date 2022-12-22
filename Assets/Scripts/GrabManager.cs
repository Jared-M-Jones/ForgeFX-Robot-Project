using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabManager : MonoBehaviour
{
    [SerializeField] private SelectionManager _selectionManager;

    private IGrabbable _grabTarget;

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
        if (_grabTarget != default)
        {
            _grabTarget.OnDropObject();
        }
        if (obj && obj.TryGetComponent<IGrabbable>(out _grabTarget))
        {
            _grabTarget.OnGrabObject(obj);
        }
    }
}
