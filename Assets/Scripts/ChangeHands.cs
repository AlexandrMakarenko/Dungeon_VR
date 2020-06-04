using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ChangeHands : MonoBehaviour
{
    public GameObject rightHandPlayer = null;
    public GameObject rightHandCamRig = null;
    public bool onOff = true;

    public SteamVR_Action_Boolean changer = null;

    private SteamVR_Behaviour_Pose m_Pose = null;

    private void Start()
    {
        m_Pose = GetComponentInParent<SteamVR_Behaviour_Pose>();
    }
    void Update()
    {
        if (changer.GetStateDown(m_Pose.inputSource))
        {
            if (onOff == false)
            {
                rightHandPlayer.gameObject.SetActive(false);
                rightHandCamRig.gameObject.SetActive(true);
                onOff = true;
            }
            else
            {
                rightHandPlayer.gameObject.SetActive(true);
                rightHandCamRig.gameObject.SetActive(false);
                onOff = false;
            }
        }
    }
}
