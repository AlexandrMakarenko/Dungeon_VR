using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerOnMenu : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    //public GameObject player;
    //public Transform Head;

    public CharacterController characterController;

    private void Start()
    {
        //player = (GameObject)this.gameObject;
        //Head = SteamVR_Render.Top().head;
    }

    void Update()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
    }
    private void CalculateMovement()
    {
        //Figure out movement orientation
        Vector3 orientationEuler = new Vector3(0, transform.eulerAngles.y, 0);
        Quaternion orientation = Quaternion.Euler(orientationEuler);
        Vector3 movement = Vector3.zero;

        //If not moving. Если отпусаем тачпад
        if (input.axis.magnitude < 0.1f)
            speed = 0;

        //If button pressed
        if (input.axis.magnitude > 0.1f)
        {
            //Add clamp
            speed += input.axis.y * 1f;
            speed = Mathf.Clamp(speed, -speed * 0.5f, 2f); //скорость вперед назад и максимальная

            //Orientation
            movement += orientation * (speed * Vector3.forward) * Time.deltaTime;//перемещие вперед, туда ,куда смотрим 
        }

        //Apply
        characterController.Move(movement);
    }
}
