using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    public Grabber _grabber;

    public void OnGrabObject(Transform obj)
    {
       // _grabber.transform = obj;
    }

    public void OnDropObject()
    {

    }

}

public interface IGrabbable
{
    public void OnGrabObject(Transform obj);
    public void OnDropObject();
}