﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTemp : MonoBehaviour {

	public void Start ()
	{
		StartCoroutine (DestroyTempObj ());
	}
	IEnumerator DestroyTempObj ()
	{
		yield return new WaitForSecondsRealtime (0.1f);
		Destroy (gameObject);
	}
}
