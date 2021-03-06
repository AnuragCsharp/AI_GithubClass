﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollow : MonoBehaviour
{
	public GameObject[] Arr_WayPoints;
	int currentWP = 0;

	public float speed = 5.0f;
	public float accuracy = 1.0f;
	public float rotspeed = 4.4f;

	private void Start()
	{
		//we are getting all the WayPoints Sphere Object inside our Array
		Arr_WayPoints = GameObject.FindGameObjectsWithTag("WayPoint");
	}

	private void LateUpdate()
	{
		if (Arr_WayPoints.Length == 0) return;

		Vector3 lookAtGoal = new Vector3(Arr_WayPoints[currentWP].transform.position.x, this.transform.position.y, Arr_WayPoints[currentWP].transform.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotspeed);

		if (direction.magnitude < accuracy) // to check if we are close enough to particular waypoint
		{
			currentWP++; //we increase
			if (currentWP >= Arr_WayPoints.Length)// if we reach to end go back to first one
			{
				currentWP = 0;
			}
		}

		this.transform.Translate(0, 0, speed * Time.deltaTime);
		
	}
}
