using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{
    public string SceneName;
    //public string OldSceneName;

    //private Transform OldPosition;
    //public GameObject Player;
    //public Transform NewPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
