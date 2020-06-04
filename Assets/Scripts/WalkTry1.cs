using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkTry1 : MonoBehaviour
{
    public Transform checkpoint = null;

    // Start is called before the first frame update
    void Start()
    {
        
       // NavMeshAgent.destination = checkpoint.position; //передвижение к нексту
    }
    void move()
    {
       // Checkpoint point = checkpoint.GetComponent<Checkpoint>();
        //checkpoint = point.getNext();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
