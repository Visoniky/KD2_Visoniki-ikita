using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SferasKontrole : MonoBehaviour
{
    
private float horMove;
private float verMove;
public float speed = 10.0f;
public Rigidbody rb;




// Start is called before the first frame update
void Start()
{
    rb = GetComponent<Rigidbody>();
}

// Update is called once per frame
void Update()
{

}

void FixedUpdate()
{
    horMove = Input.GetAxis("Horizontal");
    verMove = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(horMove, 0.0f, verMove);
    rb.AddForce(movement * speed);
}

void LateUpdate()
{

}


}
