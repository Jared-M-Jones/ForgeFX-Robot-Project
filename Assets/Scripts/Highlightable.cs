using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Highlightable : MonoBehaviour, IHighlightable, ISelectable
{
    [SerializeField] private HighlightData _highlightData = default;
    [SerializeField] private List<Renderer> _rendererList = default;

    private Dictionary<Renderer, Material> _rendererMap = default;

    public bool HoverActive { get; private set; }
    public bool Selected { get; private set; }

    [ContextMenu("Fill Renderers")]
    private void PopulateRenderer()
    {
        _rendererList = GetComponentsInChildren<Renderer>().ToList();
    }

    private void Awake()
    {
        _rendererMap = _rendererList.ToDictionary(r => r, r => r.sharedMaterial);
    }

    public void OnHoverEnter()
    {
        HoverActive = true;
        UpdateState();
    }
    public void OnHoverExit()
    {
        HoverActive = false;
        UpdateState();
    }

    public void OnSelectObject()
    {
        Selected = true;
        UpdateState();
    }

    public void OnDeselectObject()
    {
        Selected = false;
        UpdateState();
    }

    private void UpdateState()
    {
        var targetMaterial = GetStateMaterial();
        foreach (var kvp in _rendererMap)
        {
            kvp.Key.material = targetMaterial 
                ? targetMaterial 
                : kvp.Value;
        }   
    }

    private Material GetStateMaterial()
    {
        if (Selected) return _highlightData.Selected;
        return HoverActive ? _highlightData.Hover : null;
    }
}