using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    public float m_Sensitivity = 0.1f;
    public float maxSpeed = 1.0f;

    public SteamVR_Action_Boolean MovePress = null;
    public SteamVR_Action_Vector2 MoveValue = null;

    private float mySpeed = 0.0f;

    private CharacterController m_CharacterController = null;
    private Transform m_CameraRig = null;
    private Transform m_Head = null;

    private void Awake()
    {
        //Берем CharacterController с объекта
        m_CharacterController = GetComponent<CharacterController>();   
    }

    private void Start()
    {
        //Получаем объект (игрока) и головы(шлема)
        m_CameraRig = SteamVR_Render.Top().origin;
        m_Head = SteamVR_Render.Top().head;
    }

    private void Update()
    {
       // HandleHead();
        HandleHeight();
        CalculateMovement();
    }

    //private void HandleHead()
    //{
    //    //Store current
    //    Vector3 oldposition = m_CameraRig.position;
    //    Quaternion oldRotation = m_CameraRig.rotation;

    //    //Rotation
    //    transform.eulerAngles = new Vector3(0.0f, m_Head.rotation.eulerAngles.y, 0.0f);

    //    //Restore
    //    m_CameraRig.position = oldposition;
    //    m_CameraRig.rotation = oldRotation;
    //}
    private void CalculateMovement()
    {
        //Figure out movement orientation
        Vector3 orientationEuler = new Vector3(0, transform.eulerAngles.y, 0);
        Quaternion orientation = Quaternion.Euler(orientationEuler);
        Vector3 movement = Vector3.zero;

        //If not moving. Если отпусаем тачпад
        if (MovePress.GetStateUp(SteamVR_Input_Sources.Any))
            mySpeed = 0;

        //If button pressed
        if (MovePress.state)
        {
            //Add clamp
            mySpeed += MoveValue.axis.y * m_Sensitivity; 
            mySpeed = Mathf.Clamp(mySpeed, -mySpeed * 0.5f, maxSpeed); //скорость вперед назад и максимальная

            //Orientation
            movement += orientation * (mySpeed * Vector3.forward) * Time.deltaTime;//перемещие вперед, туда ,куда смотрим 
        }

        //Apply
        m_CharacterController.Move(movement);
    }

    private void HandleHeight()
    {
        //Get the head in local space
        float headHeight = Mathf.Clamp(m_Head.localPosition.y, 1, 2);
        m_CharacterController.height = headHeight;

        //Cut in half
        Vector3 newCenter = Vector3.zero;
        newCenter.y = m_CharacterController.height / 2;
        newCenter.y = m_CharacterController.skinWidth;

        //Move capsule in locale cpase
        newCenter.x = m_Head.localPosition.x;
        newCenter.z = m_Head.localPosition.z;


        //Rotate
        newCenter = Quaternion.Euler(0, -transform.eulerAngles.y, 0) * newCenter;

        //Apply
        m_CharacterController.center = newCenter;
    }
}
