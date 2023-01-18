using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabManager : MonoBehaviour
{
    [SerializeField] private SelectionManager _selectionManager;
    [SerializeField] private Grabber _grabber = default;
 
    private void OnEnable()
    {
        _selectionManager.OnSelectionChanged += OnSelectionChanged;
    }

    private void OnDisable()
    {
        _selectionManager.OnSelectionChanged -= OnSelectionChanged;
    }

    private void OnSelectionChanged(Transform obj, RaycastHit selectionHit)
    {
        if (obj && obj.TryGetComponent<IGrabbable>(out var grabbable))
        {
            _grabber.transform.position = selectionHit.point;
            //_grabber.transform.forward = selectionHit.normal;
            _grabber.Grab(grabbable);
        }
        else
        {
            _grabber.Release();  
        }
    }

    private void Update()
    {
        if (_grabber.IsHoldingObject)
        {
            _grabber.transform.SetPositionAndRotation(default, default);
            //float zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zCoord));
        }
    }
}
