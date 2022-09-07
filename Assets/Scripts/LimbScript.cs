using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbScript : MonoBehaviour
{
    private GameObject oParent;
    private GameObject attachPoint;
    private Collider m_Collider;
    public TextManager textManager;

    private void Awake()
    {
        //oParent = transform.parent.gameObject;
        oParent = GameObject.Find("Robot_Toy");
        textManager = GameObject.Find("Canvas").GetComponent<TextManager>();
        m_Collider = GetComponent<Collider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        attachPoint = new GameObject("Attach Point");
        attachPoint.transform.position = transform.position;
        attachPoint.transform.parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        CheckAttached();
        //DetachChildren();
    }

    private void CheckAttached()
    {
        if (gameObject.name == "Robot_Upperarm_Right")
        {
            if(m_Collider.bounds.Contains(attachPoint.transform.position))
            {
                transform.parent = oParent.transform.parent;
                textManager.rightUpdate = 0;
            }
            else
            {
                transform.parent = transform.root;
                textManager.rightUpdate = 1;
            }
        }

        if(gameObject.name == "Robot_Upperarm_Left")
        {
            if (m_Collider.bounds.Contains(attachPoint.transform.position))
            {
                textManager.leftUpdate = 0;
            }
            else
            {
                textManager.leftUpdate = 1;
            }
        }
    }

    private void DetachChildren()
    {
        if(textManager.rightUpdate == 0)
        {

        }
    }
}
