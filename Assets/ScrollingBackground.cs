﻿using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	}
}
