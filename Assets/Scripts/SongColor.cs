using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SongColor : MonoBehaviour
{
    public GameObject gObject = null;
    public Material[] material;
   // public AudioSource song;

    // Start is called before the first frame update
    void Start()
    {
        //song.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            Pause();
    }

    public IEnumerator Pause()
    {
        for (int i = 0; i < material.Length; i++)
        {
            int randomNumber = Random.Range(0, material.Count());
            this.GetComponent<MeshRenderer>().material = material[randomNumber];

            yield return new WaitForSeconds(1f);
        }
    }
}
