using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingle : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] plr = GameObject.FindGameObjectsWithTag("player");

        if (plr.Length > 1)
        {
            Destroy(this.gameObject);
        }

       //DontDestroyOnLoad(this.gameObject);
    }
}
