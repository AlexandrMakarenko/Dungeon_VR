using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowAutoPoint : MonoBehaviour
{
    public Text text;
    public Button button;

    private void Start()
    {
        text.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }

        
    }

}
