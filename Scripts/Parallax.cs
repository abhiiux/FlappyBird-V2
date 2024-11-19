using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public float value = 1f;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        parallax();
    }

    public void parallax()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(value * Time.deltaTime, 0);
    }   
}
