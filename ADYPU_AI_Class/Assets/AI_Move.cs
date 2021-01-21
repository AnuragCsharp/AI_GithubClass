using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Move : MonoBehaviour
{


	public GameObject ManPlayer;
	public GameObject DestinationGoalObject;

	// Start is called before the first frame update
	void Start()
	{
		this.transform.position = DestinationGoalObject.transform.position;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
