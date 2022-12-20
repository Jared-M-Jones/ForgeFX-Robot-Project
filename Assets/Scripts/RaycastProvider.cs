using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastProvider : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;

    private Transform _selection;

    private Ray CreateRayAtMousePointer()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void CheckRayHit(Ray ray)
    {
        _selection = null;
        if (Physics.Raycast(ray, out var hit, _layer))
        {
            var selection = hit.transform;
            _selection = selection;

            Debug.DrawRay(ray.origin, ray.direction);
            Debug.Log(hit.collider, hit.collider);
        }
    }

    public Transform GetSelection()
    {
        CheckRayHit(CreateRayAtMousePointer());
        return _selection;
    }
}