using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighlightArray : MonoBehaviour
{
    [field: SerializeField] protected List<Renderer> _renderer = default;

    //[SerializeField] private Color _originalColor;

    //[field: SerializeField] public Color _originalColor { get; private set; } = default;
    [field: SerializeField] public Color _highlightColor { get; private set; }  = Color.red;

    private Dictionary<Renderer, Material[]> _originalColor = new Dictionary<Renderer, Material[]>();


    private void Awake()
    {
        foreach (var rend in _renderer)
        {
            _originalColor[rend] = rend.materials;
        }
    }

    private void Update()
    {
        OnHover();
        OffHover();
    }

    private void OnHover()
    {
        foreach (var rend in _renderer)
        {
            rend.material.color = _highlightColor;
        }
    }

    private void OffHover()
    {
        foreach (var rend in _renderer)
        {
            rend.materials = _originalColor[rend];
        }
    }

    private void OnDrawGizmos()
    {
        
    }

}
