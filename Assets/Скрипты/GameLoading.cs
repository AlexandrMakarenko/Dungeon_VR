using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
    public GameObject loadingInfo, loadingIcon;

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
        if (other.gameObject.tag == "Player")
            async.allowSceneActivation = true;

    }
}
