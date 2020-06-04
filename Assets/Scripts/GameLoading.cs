using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class GameLoading : MonoBehaviour
{
    public GameObject loadingInfo, loadingIcon;
    public GameObject Pla = null;
    public Scene scene;
    public Transform Spawn = null;

    private AsyncOperation async;

    IEnumerator Start()
    {
        async = SceneManager.LoadSceneAsync(GameMenedjer.levelName);
        loadingIcon.SetActive(true);
        loadingInfo.SetActive(false);
        yield return true;
        async.allowSceneActivation = false;
        loadingIcon.SetActive(false);
        loadingInfo.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        Pla.transform.position = Spawn.position;
        if (other.gameObject.tag == "Player")
        async.allowSceneActivation = true;
        SceneManager.MoveGameObjectToScene(Pla , scene);
        
    }
}
