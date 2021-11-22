using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kieru : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="apple")
        {
            Destroy(other.gameObject);
        }
    }
}
