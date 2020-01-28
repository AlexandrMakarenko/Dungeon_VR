using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class shooting : MonoBehaviour
{

    public SteamVR_Action_Boolean Shoot = null;
    public SteamVR_Action_Boolean Reloading = null;

    private SteamVR_Behaviour_Pose Pose = null;
    private Animator Animator = null;

    public int ShotPower = 10;
    public int MaxAmmo = 9;
    private int currentammo;
    public float ReloadTime = 1.0f;

    public TMPro.TextMeshPro text;
    public GameObject line;
    public GameObject casingPrefab;
    public GameObject muzzlePrefab;
    public Transform Barrel = null;
    public GameObject BulletPrefab = null;
    public Text AmmoOutput = null;

    public AudioSource source;
    public AudioClip fire;
    public AudioClip reload;
    public AudioClip noAmmo;

    // Start is called before the first frame update
    void Start()
    {
        if (Barrel == null)
            Barrel = transform;

        Reload();
    }

    void Reload()
    {
        currentammo = MaxAmmo;
        source.PlayOneShot(reload);
    }

    // Update is called once per frame
    void Update()
    {
        if (Shoot.GetStateDown(Pose.inputSource))
        {
            if (currentammo > 0)
                GetComponent<Animator>().SetTrigger("Fire");
            else
                source.PlayOneShot(noAmmo);
        }

        if (Reloading.GetStateDown(Pose.inputSource))
            Reload();

        text.text = currentammo.ToString();
    }

    private void Fire()
    {
        GameObject tempFlash;
        if (BulletPrefab)
            Instantiate(BulletPrefab, Barrel.position, Barrel.rotation).GetComponent<Rigidbody>().AddForce(Barrel.forward * ShotPower);
        tempFlash = Instantiate(muzzlePrefab, Barrel.position, Barrel.rotation);

        RaycastHit hitInfo;
        bool hasHit = Physics.Raycast(Barrel.position, Barrel.forward, out hitInfo, 100);

        if(line)
        {
            GameObject liner = Instantiate(line);
            liner.GetComponent<LineRenderer>().SetPositions(new Vector3[] { Barrel.position, hasHit ? hitInfo.point:
                Barrel.position + Barrel.forward * 100});
            Destroy(liner, 0.5f);
        }

        void CasingRelease()
        {

        }
    }
}
