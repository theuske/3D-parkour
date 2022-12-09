﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour

{

	public Transform chController;
	bool inside = false;
	public float speedUpDown = 1.9f;
	public SC_FPSController FPSInput;

	void Start()
	{
		FPSInput = GetComponent<SC_FPSController>();
		inside = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ladder")
		{
			FPSInput.enabled = false;
			inside = !inside;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Ladder")
		{
			FPSInput.enabled = true;
			inside = !inside;
		}
	}

	void Update()
	{
		if (inside == true && Input.GetKey("w"))
		{
			chController.transform.position += Vector3.up / speedUpDown;
		}

		if (inside == true && Input.GetKey("s"))
		{
			chController.transform.position += Vector3.down / speedUpDown;
		}
	}

}

public class FirstPersonController
{
}