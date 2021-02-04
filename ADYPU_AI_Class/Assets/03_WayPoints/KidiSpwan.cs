using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidiSpwan : MonoBehaviour
{
	public GameObject TankPrefab;
	public Transform[] PositionT;

	private WayPointFollow waypointclass;

	private void Start()
	{

		waypointclass = FindObjectOfType<WayPointFollow>();
		waypointclass.ScoreKeeper_prop = 50;

		waypointclass.Krishna();



		Debug.Log("Condition k baad kya value doge chahca " + waypointclass.ScoreKeeper_prop);

		int  test= Random.Range(0, PositionT.Length); 
		GameObject TankObj =  Instantiate(TankPrefab, this.transform);
		TankObj.transform.position = PositionT[test].position;


	}
}
