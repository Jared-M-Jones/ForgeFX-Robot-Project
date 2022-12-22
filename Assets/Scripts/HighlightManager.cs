using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightManager : MonoBehaviour
{
    [SerializeField] private SelectionManager _selectionManager;

    private IHighlightable _hoverTarget;
    private ISelectable _selectionTarget;

    private void OnEnable()
    {
        _selectionManager.OnHoverChanged += OnHoverChanged;
        _selectionManager.OnSelectionChanged += OnSelectionChanged;
    }

    private void OnDisable()
    {
        _selectionManager.OnHoverChanged -= OnHoverChanged;
        _selectionManager.OnSelectionChanged -= OnSelectionChanged;
    }

    private void OnHoverChanged(Transform obj)
    {
        _hoverTarget?.OnHoverExit();
        if (obj && obj.TryGetComponent(out _hoverTarget))
        {
            _hoverTarget.OnHoverEnter();
        }
    }

    private void OnSelectionChanged(Transform obj)
    {
        _selectionTarget?.OnDeselectObject();
        if (obj && obj.TryGetComponent(out _selectionTarget))
        {
            _selectionTarget.OnSelectObject();
        }
    }
}
