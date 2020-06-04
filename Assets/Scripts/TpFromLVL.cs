using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TpFromLVL : MonoBehaviour
{

    public SteamVR_Action_Boolean menu = null;
    Transform menuSpawn;

    public GameObject playerMenu;
    

    private SteamVR_Behaviour_Pose m_Pose = null;

    //public bool first = true;
    public bool istp = true;

    public Transform pMenu;
    public Transform pLvl;



    private void Start()
    {

        m_Pose = GetComponentInParent<SteamVR_Behaviour_Pose>();
    }
    

    void Teleport()
    {
        playerMenu.transform.position = menuSpawn.position;
        playerMenu.transform.rotation = menuSpawn.rotation;
    }

    private void Update()
    {
        
            if (menu.GetStateDown(m_Pose.inputSource))
            {
            if (istp == false)
            {
                menuSpawn = GameObject.Find("Точка Около Меню").transform;
                Teleport();
                istp = true;
            }  else
            {
                menuSpawn = GameObject.Find("CubeLVL").transform;
                Teleport();
                istp = false;
            }
            }
    }
    
        
}
