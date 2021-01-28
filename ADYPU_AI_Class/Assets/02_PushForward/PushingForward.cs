using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PushingForward : MonoBehaviour
{
	
	public float speed;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Z))
		{
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.X))
		{
			this.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.Y))
		{
			this.transform.Translate(Vector3.up * speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate(0,0,-speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate( -speed * Time.deltaTime,0,0);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(0, -speed * Time.deltaTime,0);
		}

	}
}
