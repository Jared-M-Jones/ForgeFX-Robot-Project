using UnityEngine;

public abstract class HighlightSelectionResponse : MonoBehaviour
{
    [SerializeField] public Color _highlightColor = Color.red;
    [SerializeField] public Color _defaultColor = Color.white;

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