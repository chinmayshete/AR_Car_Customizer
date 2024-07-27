using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color[] color;
    public Renderer[] materials;

     public void Red()
    {
        for(int i = 0; i < materials.Length; i++)
        {
            materials[i].material.color = color[0];
        }
    }

    public void Blue()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].material.color = color[1];
        }
    }

    public void Green()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].material.color = color[2];
        }
    }

    public void Yellow()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].material.color = color[3];
        }
    }
}
