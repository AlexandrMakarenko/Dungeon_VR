using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject ammoPlus = null;

    public void destroying()
    {
        ammoPlus.SetActive(false);
    }

    public void PlusAmmo()
    {
        
    }

}
