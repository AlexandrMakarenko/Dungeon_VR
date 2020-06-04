using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Shooting : MonoBehaviour
{
    public SteamVR_Action_Boolean tap = null;
    public SteamVR_Action_Boolean rTap = null;
    public Transform patron = null;
    public Rigidbody bullet = null;
    public Text textAmmo = null;
    public Text ammoMax = null;

    public Transform pistol = null;
    public GameObject decal = null;

    public string[] targetTags = { "Enemy1", "Enemy2" };

    public float damage = 10;
    public float bulletSpeed = 100f;

    public int maxAmmo = 100;
    public int maxAmmoInClip = 9;
    public int gunAmmo = 0;

    public float range = 100f;

    public AudioClip fireSound;
    public AudioClip reloadSound;

    AudioSource audio;

    public bool canShoot = true;


    //private float curTimeout;
    private SteamVR_Behaviour_Pose m_Pose = null;

    private void Awake()
    {
        audio = gameObject.AddComponent<AudioSource>();
        gunAmmo = maxAmmoInClip;
    }
    void Start()
    {
        m_Pose = GetComponentInParent<SteamVR_Behaviour_Pose>();
        ammoMax.text = maxAmmo.ToString();

    }

    void Update()
    {
        Shoot();
        ammoMax.text = maxAmmo.ToString();
        Debug.DrawRay(pistol.position, pistol.forward * 10f);

        if (tap.GetStateDown(m_Pose.inputSource) & canShoot)
        {
            shoot();
        }
        if (rTap.GetStateDown(m_Pose.inputSource) & canShoot && gunAmmo != maxAmmo &&  gunAmmo != maxAmmoInClip)
        {
            canShoot = false;
            StartCoroutine(CoroutineReload());
        }
    }

    public void shoot()
    {

        gunAmmo--;
        textAmmo.text = gunAmmo.ToString();
        ammoMax.text = maxAmmo.ToString();
        audio.PlayOneShot(fireSound);

        Vector3 DirectionRay = pistol.transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawLine(pistol.position, pistol.forward * range, Color.red);

        if(Physics.Raycast(pistol.position, DirectionRay, out hit, range))
        {
            if(hit.collider)
            {
                Debug.Log("Shoot in |" + hit.collider.name + "| at a distance |" + hit.distance + "|");
            }
            foreach(string currentTag in targetTags)
            {
                if(currentTag == hit.transform.tag)
                {
                    hit.transform.GetComponent<EnemyHealth>().AddDamage(damage);
                }
            }
        }

        if (gunAmmo == 0)
        {
            StartCoroutine(CoroutineReload());
            textAmmo.text = gunAmmo.ToString();
            ammoMax.text = maxAmmo.ToString();
        }

        Ray ray = new Ray(pistol.position, pistol.forward * 10f);
        //RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject g = Instantiate<GameObject>(decal);
            Rigidbody bulletInstance = Instantiate(bullet, patron.position, Quaternion.identity) as Rigidbody;
            bulletInstance.velocity = patron.forward * bulletSpeed;
            g.transform.position = hit.point + hit.normal * 0.01f;//чтобы была декаль не в стене, а перед ней
            g.transform.rotation = Quaternion.LookRotation(-hit.normal);
            g.transform.SetParent(hit.transform);
            Rigidbody r = hit.transform.gameObject.GetComponent<Rigidbody>();
            if (r != null)
            {
                r.AddForceAtPosition(-hit.normal * 1000f, hit.point);
            }
        }
    }

    public IEnumerator CoroutineReload()
    {
        canShoot = false;

        yield return new WaitForSeconds(0.2f);
        audio.PlayOneShot(reloadSound);

        yield return new WaitForSeconds( 1f);

        var ammo = 0;
        if (gunAmmo > 0) 
        { 
            ammo = gunAmmo; gunAmmo = 0; 
        }
        if( maxAmmoInClip > maxAmmo)
        {
            if(maxAmmo + ammo > maxAmmoInClip)
            {
                gunAmmo = maxAmmoInClip;
                maxAmmo = maxAmmo + ammo - maxAmmoInClip;

                textAmmo.text = gunAmmo.ToString();
                ammoMax.text = maxAmmo.ToString();
            }
            else
            {
                gunAmmo = maxAmmo + ammo;
                maxAmmo = 0;

                textAmmo.text = gunAmmo.ToString();
                ammoMax.text = maxAmmo.ToString();
            }
        }
        else
        {
            gunAmmo = maxAmmoInClip;
            maxAmmo = maxAmmo - maxAmmoInClip + ammo;
            textAmmo.text = gunAmmo.ToString();
            ammoMax.text = maxAmmo.ToString();
        }
        canShoot = true;
        if (maxAmmo == 0 & gunAmmo ==0)
        {
            canShoot = false;
            textAmmo.text = "-";
            ammoMax.text = maxAmmo.ToString();
        }
    }

    public void ammoPlus()
    {
        maxAmmo += 9; //System.Random.Range(0, 10);
        ammoMax.text = maxAmmo.ToString();
    }

    public void Shoot()
    {
        if(maxAmmo != 0 && maxAmmoInClip != 0 && gunAmmo != 0)
        {
            canShoot = true;
        }
    }
}
