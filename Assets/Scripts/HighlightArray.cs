using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// highlights the gameObject and it's children on mouseover

public class HighlightArray : MonoBehaviour
{
    private Renderer[] m_Renderer;

    public Color m_OriginalColor;

    public Color m_HighlightColor = Color.red;


    private void Awake()
    {
        // fetch the renderer component from the target and it's children and stores it in an array
        m_Renderer = GetComponentsInChildren<Renderer>();

        // fetch the original color of the target
        m_OriginalColor = GetComponent<Renderer>().material.color;  
    }

    private void OnMouseEnter()
    {
        // set target and it's children colors to red when the mouse is over target
        foreach (var rend in m_Renderer)
        {
            rend.material.color = m_HighlightColor;
        }
    }

    private void OnMouseExit()
    {
        // set target and it's children colors back to it's original color
        foreach (var rend in m_Renderer)
        {
            rend.material.color = m_OriginalColor;                 
        }
    }
}
