using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnRightRoom : MonoBehaviour
{
    public GameObject Door = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            Destroy(Door);
            Destroy(other);
        }
    }

}
