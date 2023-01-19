using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastProvider : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    private RaycastHit _lastHit;
    private Transform _selection;

    private Ray CreateRayAtMousePointer()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void CheckRayHit(Ray ray)
    {
        _selection = null;
        if (Physics.Raycast(ray, out _lastHit, _layer))
        {
            var selection = _lastHit.transform;
            _selection = selection;

            Debug.DrawRay(ray.origin, ray.direction);
            Debug.Log(_lastHit.collider, _lastHit.collider);
        }
    }

    public Transform GetSelection(out RaycastHit hit)
    {
        CheckRayHit(CreateRayAtMousePointer());
        hit = _lastHit;
        return _selection;
    }
}