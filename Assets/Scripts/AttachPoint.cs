using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPoint : MonoBehaviour
{
    private IAttachable _attachable;

    public void Attach(IAttachable attachable)
    {
        _attachable = attachable;

    }

    public void Detach()
    {
        _attachable = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.01f);
    }
}

