using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightRobot : MonoBehaviour
{
    private Renderer rend;
    private Color startColor;
    public Color hoverColor;
    // Start is called before the first frame update
    void Start()
    {
            rend = GetComponent<Renderer>();
            startColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
