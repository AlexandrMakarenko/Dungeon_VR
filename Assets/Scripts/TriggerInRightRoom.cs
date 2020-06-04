using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInRightRoom : MonoBehaviour
{
    public GameObject wall = null;
    public GameObject tr = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            wall.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            wall.SetActive(false);
            tr.SetActive(false);
        }
    }
}
