using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemys : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;
    public GameObject player;

    public float visible = 5f;
    public float angleV = 70f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < 1.5f)
            {
                //играем анимации атаки или еще чего
            }
            else if (distance < visible)
            {
                Quaternion look = Quaternion.LookRotation(player.transform.position - transform.position);
                float angle = Quaternion.Angle(transform.rotation, look);
                if (angle < angleV)
                {
                    RaycastHit hit;
                    Ray ray = new Ray(transform.position + Vector3.up, player.transform.position - transform.position + Vector3.up);
                    if (Physics.Raycast(ray, out hit, visible))
                    {
                        if (hit.transform.gameObject == player)
                        {
                            agent.destination = player.transform.position;
                        }
                    }
                   
                }
            }
        }



        if (agent.velocity.magnitude > 2f)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }
}
