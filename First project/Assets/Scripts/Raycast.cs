using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        this.ray = new Ray(this.transform.position, this.transform.forward);
        Physics.Raycast(ray);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * 10, Color.red);
        GameObject.Find("Explosion").SetActive(Physics.RaycastAll(this.ray).Any());
    }
}
