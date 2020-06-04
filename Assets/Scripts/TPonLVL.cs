using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TPonLVL : MonoBehaviour
{
    public bool teleported = false;

    public GameObject PonLVL = null;
    public GameObject PonMenu = null;

    void OnTriggerEnter(Collider other)
    {       
        if(other.gameObject.tag == "Player")
            if (!teleported)
         //other.gameObject.transform.position  = PonLVL.gameObject.transform.position;
        PonMenu.transform.position = PonLVL.gameObject.transform.position;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            teleported = false;
    }
}
