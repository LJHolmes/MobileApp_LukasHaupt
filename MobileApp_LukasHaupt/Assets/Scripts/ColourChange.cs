using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private MeshRenderer rend;

    public Color colourRed;
    public Color colourGreen;
    public Color colourWhite;

    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        rend.material.color = colourRed;
    }

    public void ButtonChangeColour()
    {
        if (rend.material.color == colourGreen)
        {
            rend.material.color = colourWhite;
            return;
        }

        if (rend.material.color == colourWhite)
        {
            rend.material.color = colourGreen;
            return;
        }

        rend.material.color = colourGreen;
    }
}
