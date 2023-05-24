using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{


    [SerializeField] private Transform Platform;
    private void Awake()
    {
        Instantiate(Platform, new Vector3(13, 4), Quaternion.identity);
    }
}
