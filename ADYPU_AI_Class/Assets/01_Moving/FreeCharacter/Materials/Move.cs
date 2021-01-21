using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{



	[SerializeField]	private Vector3		goal = new Vector3(5,0,4);
	[SerializeField]	private Vector3		InitialPosition;
						public GameObject	Goal_Object;



	void Start () 
	{
		InitialPosition = this.transform.position;		
	//	this.transform.Translate(goal); //this Referers to The object where Script is attached to :) 
	}
	
	void LateUpdate () 
	{
		this.transform.LookAt(Goal_Object.transform);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.transform.Translate(goal);	
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			this.transform.position = InitialPosition;
		}

		if (Input.GetKey(KeyCode.S))
		{
			this.transform.Translate( goal * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			Vector3 position = new Vector3(0,0,0);
			position =  Goal_Object.transform.position - this.transform.position;
			this.transform.position = position;
		}

		
	}
}
