using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPlus : MonoBehaviour
{
    public Shooting pistol;
    //public GameObject cube;
    //public Text textAmmo;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "AmmoPlus")
        {
            pistol.ammoPlus();
            other.gameObject.SetActive(false);
        }
    }
}
