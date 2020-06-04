using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SpriteRenderer))]
public class Elevator : MonoBehaviour
{
	public GameObject elevator = null;
	public Transform pos1 = null;
	public Transform pos2 = null;
	public int VectorMove = 1;
	public float speedElevator = 0.02f;

	public void UpElevator()
	{
		// получаем позицию лифта
		
		
		do {
			Vector3 E = elevator.transform.position;
			E.y = E.y + speedElevator + VectorMove * Time.deltaTime;
			elevator.transform.position = E;
		}
		while (pos1.position.y < pos2.position.y);
	}
}
