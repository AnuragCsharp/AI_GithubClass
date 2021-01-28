using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJill : MonoBehaviour
{


	public Transform goal;
	public float speed = 0.5f;
	public float accuracy = 1;
	
	
	public float rotSpeed = 0.1f;
	private void LateUpdate()
	{
		Vector3 LookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);


		//this is the Direction what we need to face !
		Vector3 direction = LookAtGoal - this.transform.position;

		//Replace with LookAt to this SLERP code to see in action.
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);



		//we dont have direction so we will perfomr this  // Remove below for Animation Root Motion
		//if (Vector3.Distance(transform.position, LookAtGoal) > accuracy)
		//{
		//	this.transform.Translate(0, 0, speed * Time.deltaTime);
		//}
	}

}


public class SlerpClass : MoveJill
{
	public Transform goal;
	public float speed = 0.5f;
	public float accuracy = 1;
	public float rotSpeed = 0.1f;
	private void LateUpdate()
	{
		Vector3 LookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);


		//this is the Direction what we need to face !
		Vector3 direction = LookAtGoal - this.transform.position;

		//Replace with LookAt to this SLERP code to see in action.
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

		

		//we dont have direction so we will perfomr this  // Remove below for Animation Root Motion
		if (Vector3.Distance(transform.position, LookAtGoal) > accuracy)
		{
			this.transform.Translate(0, 0, speed * Time.deltaTime);
		}
	}

}