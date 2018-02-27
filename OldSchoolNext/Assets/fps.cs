using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fps : MonoBehaviour {

	public Text fpstext;
	public float lastUpdate;

	// Use this for initialization
	void Start () {
		lastUpdate = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > lastUpdate + 0.5f)
		{
			int ifps = (int) (1 / Time.deltaTime);
			fpstext.text = ifps.ToString()+" fps";
			lastUpdate = Time.time;
		}


		
	}
}
