using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{

<<<<<<< HEAD
    public float speed = 2.0f;
    public float accuracy = 0.01f;
    public Transform goal;
    public Transform goal2;



    void LateUpdate()
    {
        Vector3 FirstGoalDirection = goal.position - this.transform.position;  
        Vector3 SecondGoalDirection = goal2.position - this.transform.position; 
       
        if (this.gameObject.name == "Man")
        { 
            Debug.DrawRay(this.transform.position, FirstGoalDirection, Color.red);
            this.transform.LookAt(goal.position);

            if (Input.GetKey(KeyCode.Space))
            {
                if (FirstGoalDirection.magnitude > accuracy)
                {
                    this.transform.Translate(FirstGoalDirection.normalized * speed * Time.deltaTime, Space.World);
                }
            }

        }
        else
        {
            Debug.DrawRay(this.transform.position, SecondGoalDirection, Color.green);
            this.transform.LookAt(goal2.position);

            if (Input.GetKey(KeyCode.P))
            {
                if (SecondGoalDirection.magnitude > accuracy)
                {
                    this.transform.Translate(SecondGoalDirection.normalized * speed * Time.deltaTime, Space.World);
                }
            }

        }
    }
=======
	public	float		speed = 2.0f;
	public	float		accuracy = 5;
	public	Transform	goal;
	public  Transform	goal2;


	
	void LateUpdate()
	{
		Vector3 FirstGoalDirection = goal.position - this.transform.position; // this is our first position
		Vector3 SecondGoalDirection = goal2.position - this.transform.position; // this is second position

		if (this.gameObject.name == "Man")
		{
			Debug.DrawRay(this.transform.position, FirstGoalDirection, Color.red);
			this.transform.LookAt(goal.position);

			if (Input.GetKey(KeyCode.Space))
			{
				if (FirstGoalDirection.magnitude > accuracy)
				{
					this.transform.Translate(FirstGoalDirection.normalized * speed * Time.deltaTime, Space.World);
				}
			}

		}
		else
		{
			Debug.DrawRay(this.transform.position, SecondGoalDirection, Color.green);
			this.transform.LookAt(goal2.position);

			if (Input.GetKey(KeyCode.P))
			{
				if (SecondGoalDirection.magnitude > accuracy)
				{
					this.transform.Translate(SecondGoalDirection.normalized * speed * Time.deltaTime, Space.World);
				}
			}
		}



	}
>>>>>>> 8399b3265d074051930d990581087129522d808f
}


