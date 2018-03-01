using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.fixedDeltaTime = 1f / 144f;
		Screen.SetResolution(765, 503, false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
