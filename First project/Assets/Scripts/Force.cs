using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float thrust = 10;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody>();
    }
        
    // Update is called once per frame
    void FixedUpdate()
    {
        this.rigidbody.AddForce(Vector3.right * thrust);
    }
}