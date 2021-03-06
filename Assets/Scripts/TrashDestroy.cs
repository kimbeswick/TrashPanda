﻿using UnityEngine;
using System.Collections;

public class TrashDestroy : MonoBehaviour {

	[SerializeField]
	public AudioSource soundEffect;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(!soundEffect.isPlaying)
			soundEffect.Play ();
		Destroy(gameObject);
	}
}
