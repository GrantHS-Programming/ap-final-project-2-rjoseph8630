using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundloop : MonoBehaviour
{
    public float backgroundspeed;
    public Renderer backgroundRenderer;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(backgroundRenderer.material.mainTexture);
        Debug.Log(backgroundspeed);
        //backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0f);
       
    }
}
