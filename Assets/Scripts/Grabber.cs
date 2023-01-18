using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public bool IsHoldingObject => _grabbable != default;
    private IGrabbable _grabbable;
    private Vector3 _lastPosition;
    
    public void Grab(IGrabbable grabbable)
    {
        _grabbable = grabbable;
        _lastPosition = transform.position;
    }

    public void Release()
    {
        _grabbable = null;
    }

    private void Update()
    {
        if (_grabbable == null) return;
        _grabbable.GameObject.transform.position += transform.position - _lastPosition;
        _lastPosition = transform.position;
    }
}
