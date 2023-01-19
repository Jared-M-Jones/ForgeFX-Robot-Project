using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour, IGrabbable
{
    public Grabber _grabber;

    public bool GrabActive { get; private set; }

    public GameObject GameObject => gameObject;

    public void OnGrabObject(Transform obj)
    {
        GrabActive = true;
        UpdateState();
    }

    public void OnDropObject()
    {
        GrabActive = false;
        UpdateState();
    }

    private void UpdateState()
    {

    }

    public void UpdatePosition(Vector3 position)
    {
        //Target Position
        //ConstraintManager.ApplyConstraints(Target Position)
        //Move to 
    }
    
    
}

public interface IGrabbable
{
    public GameObject GameObject { get; }
}