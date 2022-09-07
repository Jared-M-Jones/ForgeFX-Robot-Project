using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightArray : MonoBehaviour
{
    // stores the target's original color
    [SerializeField]
    private Color m_OriginalColor;

    // get the target and it's children's renderers to access the their materials and colors
    private Renderer[] m_Renderer;


    private void Awake()
    {
        // fetch the renderer component from the target and it's children and stores it in an array
        m_Renderer = GetComponentsInChildren<Renderer>();

        // fetch the original color of the target
        m_OriginalColor = GetComponent<Renderer>().material.color;
    }

    public void OnMouseEnter()
    {
        // set target and it's children colors to red when the mouse is over target
        foreach(var rend in m_Renderer)
        {
            rend.material.color = Color.red;
        }
    }

    public void OnMouseExit()
    {
        // set target and it's children colors back to it's original color
        foreach (var rend in m_Renderer)
        {
            rend.material.color = m_OriginalColor;
        }
    }
}
