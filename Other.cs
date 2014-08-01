using UnityEngine;
using System.Collections;

public class Other : MonoBehaviour {

	public s_ReadNeuro readNeuroInstance;

	void Start() {
	}
	
	void Update() {
		var attention = readNeuroInstance.attention;

		var blink = readNeuroInstance.blink;
		// do something with it.
	}

}
