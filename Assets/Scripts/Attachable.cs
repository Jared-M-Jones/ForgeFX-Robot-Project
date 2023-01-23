using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachable : MonoBehaviour, IAttachable
{
    public AttachPoint _attachPoint;

    public bool AttachActive { get; private set; }

    public GameObject GameObject => gameObject;

    public void OnAttachObject(Transform obj)
    {
        AttachActive = true;
        UpdateState();
    }

    public void OnDetachObject()
    {
        AttachActive = false;
        UpdateState();
    }

    private void UpdateState()
    {

    }
}

public interface IAttachable
{
    public GameObject GameObject { get; }
}
