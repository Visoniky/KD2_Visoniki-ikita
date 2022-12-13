using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    float xSpeed = 2.0f;
    float ySpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = xSpeed * Input.GetAxis("Mouse X");
        float v = ySpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);
    }
}
