using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlightable : MonoBehaviour, IHighlightable
{
    private Material _hoverMaterial;
    private Material _defaultMaterial;
    private Material _selectMaterial;

    private Renderer _renderer;
    [field: SerializeField] protected List<Renderer> _rendererList = default;
    //private Renderer[] _rendererList;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        //_rendererList = GetComponentsInChildren<Renderer>();
        _defaultMaterial = _renderer.sharedMaterial;
        _hoverMaterial = new Material(_renderer.sharedMaterial) { color = Color.red };
        _selectMaterial = new Material(_renderer.sharedMaterial) { color = Color.blue };
    }

    public void OnHoverEnter() => _renderer.material = _hoverMaterial;
    public void OnHoverExit() => _renderer.material = _defaultMaterial;

    public void OnSelectObject()
    {
        foreach (var rend in _rendererList)
        {
            rend.material = _selectMaterial;
        }
    }

    public void OnDeselectObject()
    {
        foreach (var rend in _rendererList)
        {
            rend.material = _defaultMaterial;
        }
    }
}