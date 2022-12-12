
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// checks if the arms are within their attachPoints and moves them into their original position if they are

public class LimbScript : MonoBehaviour
{
    // creates a new object at the arm's original start position as an anchor for the arm to return to
    private GameObject attachPoint;  
    
    private Collider m_Collider;

    private bool _isRightArmAttached = true;
    private bool _isLeftArmAttached = true;

    public bool RightArmAttached => _isRightArmAttached;
    public bool LeftArmAttached => _isLeftArmAttached;
    /*
    private void Awake()
    {
        textManager = GameObject.Find("Canvas").GetComponent<TextManager>();

        m_Collider = GetComponent<Collider>();
    }

    private void Start()
    {
        attachPoint = new GameObject("Attach Point");
        attachPoint.transform.position = transform.position;
        attachPoint.transform.parent = transform.parent;
    }

    private void Update()
    {
        CheckAttached();
    }

    // if the arm is within the attachPoint's collider, set the arm's parent to the original parent and pass textManager an update
    private void OnMouseDrag()
    {
        if (gameObject.name == "Robot_Upperarm_Right")
        {
            if (m_Collider.bounds.Contains(attachPoint.transform.position))
            {
                textManager.rightUpdate = 0;

                transform.parent = attachPoint.transform.parent;
            }
            else
            {
                textManager.rightUpdate = 1;

                transform.parent = null;
            }
        }

        if (gameObject.name == "Robot_Upperarm_Left")
        {
            if (m_Collider.bounds.Contains(attachPoint.transform.position))
            {
                textManager.leftUpdate = 0;

                transform.parent = attachPoint.transform.parent;
            }
            else
            {
                textManager.leftUpdate = 1;

                transform.parent = null;
            }
        }
    }

    // if the arm is within the attachPoint's collider, move to the original arm position
    private void CheckAttached() 
    {
        if (gameObject.name == "Robot_Upperarm_Right")
            if (textManager.rightUpdate == 0 && Input.GetMouseButton(0) == false)
            {
                transform.position = attachPoint.transform.position;
            }

        if (gameObject.name == "Robot_Upperarm_Left")
            if (textManager.leftUpdate == 0 && Input.GetMouseButton(0) == false)
            {
                transform.position = attachPoint.transform.position;
            }
    }*/
}
