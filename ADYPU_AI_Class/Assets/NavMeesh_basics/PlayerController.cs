using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

	public Camera cam;

	public NavMeshAgent agent;
	private void FixedUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			//Input.mousePosition -- its the current position of mouse onto screen co-ordinates -- we need to convert this into screen to worl co-orodinates

			Ray ray = cam.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				// set the desination of agent

				agent.SetDestination(hit.point);
			}



		}

	}
}
