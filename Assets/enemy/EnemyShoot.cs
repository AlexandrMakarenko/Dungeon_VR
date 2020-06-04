using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform gunPoint;
    public int bulletSpeed = 2;
    public float timeout = 1f;
    private float curTimeout;
    public GameObject player;
    public float visible = 10f;

    void shootPlayer()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position + Vector3.up, player.transform.position - transform.position + Vector3.up);
        if (Physics.Raycast(ray, out hit, visible))
        {
            if (hit.transform.gameObject == player)
            {
                Rigidbody bulletInstance = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody;
                bulletInstance.velocity = gunPoint.forward * bulletSpeed;
            }
        }
    }
}
