using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

	private AudioSource _audioSource;

	private void Awake() => _audioSource = GetComponent<AudioSource>();


	private void OnEnable() => ObserverTHis.OnAnyPointEnable += PlayPopAudio;

	private void OnDisable() => ObserverTHis.OnAnyPointEnable -= PlayPopAudio;	
	

	private void PlayPopAudio()
	{
		print("Play Sound Called");
		_audioSource.Play();
	}


}
