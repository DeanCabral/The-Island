﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Euler(0, 0, Mathf.PingPong(Time.time * 20f, 30));
	}
}
