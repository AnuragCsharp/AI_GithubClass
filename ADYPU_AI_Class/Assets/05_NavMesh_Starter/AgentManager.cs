using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
	GameObject[] agents;

	private void Start()
	{
		agents = GameObject.FindGameObjectsWithTag("AI");
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit Hit;

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit, 100))
			{
				foreach (GameObject a in agents)
				{
					a.GetComponent<AIControl>().agent.SetDestination(Hit.point);
				}
			}
		}

	}
}
