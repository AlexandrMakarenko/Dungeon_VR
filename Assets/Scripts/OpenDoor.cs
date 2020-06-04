using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject doorClosed = null;
    public GameObject bot = null;
    public GameObject canvas = null;
    public EnemyHealth hp;

    // Update is called once per frame
    void Update()
    {
        open();
    }

    public void open()
    {
        if (hp.HP == 10)
        {
            Destroy(doorClosed);
            Destroy(canvas);
            Destroy(bot);
        }
    }
}
