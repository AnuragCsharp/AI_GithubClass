using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour

{
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	void LateUpdate()
	{
		float	translation	 = Input.GetAxis("Vertical") * speed;
		float	rotation	 = Input.GetAxis("Horizontal") * rotationSpeed;

				translation	 *= Time.deltaTime;
				rotation	 *= Time.deltaTime;

		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}

	
	void ZombieChaseThePlayer()
	{
		// Zombie must look at Player
		// Zombie must move towards player (Attack)
		// Zombile should show debug.ray in Scene view...

		// Make sure =-- if Cube moves up and down.. ZOmbie ka angle change nhi hona chaiye !! 




	}
}