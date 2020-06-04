using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ChangeHand : MonoBehaviour
{
    public GameObject rightHandPlayer = null;
    public GameObject rightHandCamRig = null;

    private bool enter = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enter == false)
            {
                rightHandPlayer.gameObject.SetActive(false);
                rightHandCamRig.gameObject.SetActive(true);
                enter = true;
            }
            else
            {
                rightHandPlayer.gameObject.SetActive(true);
                rightHandCamRig.gameObject.SetActive(false);
                enter = false;
            }
        }
    }
}
