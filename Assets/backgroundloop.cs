using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundloop : MonoBehaviour
{
    public float backgroundspeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0f);
    }
}
