using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaJalan : MonoBehaviour
{
    public float movespeed;
    int status;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);
    }
}
