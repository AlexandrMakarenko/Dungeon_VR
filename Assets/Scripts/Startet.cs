using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Startet : MonoBehaviour
{
    public GameObject player;
    public Transform startPoint;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = startPoint.position;
        player.transform.rotation = startPoint.rotation;
    }
}
