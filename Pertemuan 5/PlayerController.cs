using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    float hInput;
    float vInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(vInput * Vector3.forward * 5 * Time.deltaTime);
        transform.Rotate(0, hInput * 100 * Time.deltaTime, 0);
    
    }
}
