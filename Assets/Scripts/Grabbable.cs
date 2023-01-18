using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour, IGrabbable
{
    public Grabber _grabber;

    public bool GrabActive { get; private set; }

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
        Debug.Log("Grabbeded: ");
    }
}

public interface IGrabbable
{
    public void OnGrabObject(Transform obj);
    public void OnDropObject();
}