using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public GameObject target;
    //public Component[] rArray;
    // stores the targetÅfs original color
    private Color m_OriginalColor;

    // get the targetÅfs mesh renderer to access the GameObjectÅfs material and color
    private Renderer m_Renderer;


    void Start()
    {
        // fetch the mesh renderer component from the target
        m_Renderer = GetComponentInChildren<Renderer>();
        // fetch the original color of the target
        m_OriginalColor = m_Renderer.material.color;

    }

    void OnMouseEnter()
    {
        // set target color to red when the mouse is over target
        m_Renderer.material.color = Color.red;
    }

    void OnMouseExit()
    {
        // set target color back to it's original color
        m_Renderer.material.color = m_OriginalColor;
    }
}
