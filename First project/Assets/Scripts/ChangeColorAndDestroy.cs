using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = Color.red;
        Object.Destroy(this.gameObject, 3);
    }

    
}
