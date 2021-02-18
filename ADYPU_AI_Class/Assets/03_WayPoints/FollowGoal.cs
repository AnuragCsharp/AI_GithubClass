using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGoal : MonoBehaviour
{

	public	float		speed = 2.0f;
	public float rotSpeed = 1.0f;
	public	Transform	goal;

	
	void LateUpdate()
	{
		Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);

		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
		
		
		this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
		
	}
}
