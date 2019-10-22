using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ThirdPersonController")
        {
            print("Un objet est entré dans la zone rouge");
        }
    }
}
