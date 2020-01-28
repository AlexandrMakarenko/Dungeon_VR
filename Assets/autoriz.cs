using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class autoriz : MonoBehaviour
{
    public Camera camVR = null;
    public Camera camnotVR = null;
    public GameObject prefab = null;
    public GameObject player = null;


    private void Start()
    {
        camVR.gameObject.SetActive(true);
        camnotVR.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Auto");
            camVR.gameObject.SetActive(false);
            //Destroy(player); изменить позицию игрокa. Поставить его перед экраном с клавой и вводить все с клавы виртуальной
            camnotVR.gameObject.SetActive(true);
            prefab.gameObject.SetActive(false);
        }
    }
}
