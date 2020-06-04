using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{
    public string SceneName;
    public GameObject Pla = null;
    public Scene scene;
    public Transform Spawn = null;
    //public string OldSceneName;

    //private Transform OldPosition;
    //public GameObject Player;
    //public Transform NewPosition;
    private void OnTriggerEnter(Collider other)
    {
        Pla.transform.position = Spawn.position;
        if (other.gameObject.tag == "Player")
        {
            GameMenedjer.levelName = SceneName;
            SceneManager.LoadScene("Loading");
            SceneManager.MoveGameObjectToScene(Pla, scene);
            
        }
    }
}
