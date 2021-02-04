using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI_Move : MonoBehaviour
{


	public GameObject ManPlayer;
	public GameObject DestinationGoalObject;

	// Start is called before the first frame update
	void Start()
	{
		this.transform.position = DestinationGoalObject.transform.position;
	}

	public void ReloadScene()
	{
		Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
	}
}
