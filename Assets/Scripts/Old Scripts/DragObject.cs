using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// moves the gameObject when clicked and dragged by a mouse

public class DragObject : MonoBehaviour
{
    private void OnMouseDrag()
    {
        // fetches the Z-axis coordinate relative to the game camera
        float zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // moves the object, and is locked to the Z-axis relative to the camera
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zCoord));
    }
}
