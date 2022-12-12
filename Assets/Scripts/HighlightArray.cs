using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighlightArray : MonoBehaviour
{
    [field: SerializeField] protected List<Renderer> _renderer = default;

    [SerializeField] private Color _originalColor;

    [field: SerializeField] public Color _highlightColor { get; private set; }  = Color.red;


    private void Awake()
    {
        _originalColor = GetComponent<Renderer>().material.color;  
    }

    private void OnMouseEnter()
    {
        foreach (var rend in _renderer)
        {
            rend.material.color = _highlightColor;
        }
    }

    private void OnMouseExit()
    {
        foreach (var rend in _renderer)
        {
            rend.material.color = _originalColor;                 
        }
    }
}
