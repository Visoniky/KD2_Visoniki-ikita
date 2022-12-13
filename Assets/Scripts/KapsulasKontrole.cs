using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    public int fps {get; private set; }
    public int counter = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fps = (int) (1.0f / Time.deltaTime);

        if(fps  >= counter)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color( Random.value, Random.value, Random.value, 1.0f );
            counter = counter + 60;
        }
    }
}
