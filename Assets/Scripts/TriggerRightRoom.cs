using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRightRoom : MonoBehaviour
{
    public GameObject finalDoor = null;
    public GameObject WallOnDoor = null;
    public GameObject trigger = null;

    private void OnTriggerExit(Collider other)
    {
        trigger.SetActive(false);
        WallOnDoor.SetActive(false);
        Destroy(finalDoor);
    }
}
