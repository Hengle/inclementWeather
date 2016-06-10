﻿using UnityEngine;
using System.Collections;

public class moveIT : MonoBehaviour {
	
		public float speed = 10.0F;
		public float pitchSpeed = 100.0F;
		
		// Update is called once per frame
		void Update () {
			float translation = Input.GetAxis("Vertical") * speed;
			float pitch = Input.GetAxis("Horizontal") * pitchSpeed;
			translation *= Time.deltaTime;
			pitch *= Time.deltaTime;
			transform.Translate(0, translation, 0, Space.World);
			transform.Rotate(0, 0, pitch * -1, Space.World);
		}
	}