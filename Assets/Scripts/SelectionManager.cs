using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private Color _highlightColor = Color.red;
    [SerializeField] private Color _defaultColor;

    private Transform _selection;

    private void Awake()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material.color = _defaultColor;
            _selection = null;
        }
    }

    void Update()
    {
        //if( Physics.Raycast (ray, out hit, layermask))
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, LayerMask.GetMask("Interactable")))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer!= null)
            {
                selectionRenderer.material.color = _highlightColor;
            }
            _selection = selection;
        }
    }

    private void OnDrawGizmos()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Gizmos.color = Color.green;
        Gizmos.DrawRay (ray.origin, Input.mousePosition);
    }
}
