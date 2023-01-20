using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabManager : MonoBehaviour
{
    [SerializeField] private SelectionManager _selectionManager;
    [SerializeField] private Grabber _grabber = default;
    [SerializeField] private float _scrollScale = 0.01f;

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
        UpdateGrabberPosition(UpdateZCoordinate());
    }

    private float UpdateZCoordinate()
    {
        float zCoord = Camera.main.WorldToScreenPoint(_grabber.transform.position).z;
        if (_grabber.IsHoldingObject)
        {
            return zCoord += Input.mouseScrollDelta.y * _scrollScale;
        }
        else
        {
            return zCoord;
        }
    }

    private void UpdateGrabberPosition(float zCoord)
    {
        _grabber.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zCoord ));

        if (_grabber.IsHoldingObject)
        {
            _grabber.transform.SetPositionAndRotation(default, default);
            _grabber.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zCoord));
        }
    }
}
