using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObserverTHis : MonoBehaviour
{
	public static event Action OnAnyPointEnable;



	private void OnMouseDown()
	{		
		
		print("Observer Sound Called");
		OnAnyPointEnable?.Invoke();
	}
}
