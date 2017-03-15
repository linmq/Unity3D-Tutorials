using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if !UNITY_EDITOR
		BrightnessControlHelper.setBrightness (1.0f);
		#endif
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnApplicationPause()
	{
		#if !UNITY_EDITOR
		BrightnessControlHelper.setBrightness (0.5f);
		#endif
	}
}
