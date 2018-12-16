using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasScalerScript : MonoBehaviour {

	void Awake () {
		ResizeCanvas ();
	}

	void Update () {
		ResizeCanvas ();
	}

	private void ResizeCanvas () {
		if(Screen.height > 2560) {
			gameObject.GetComponent<CanvasScaler>().scaleFactor = (float)((float) Screen.height / 2560f);
		} else if(Screen.height == 2560){
			gameObject.GetComponent<CanvasScaler>().scaleFactor = 1;
		} else if(Screen.height < 2560){
			gameObject.GetComponent<CanvasScaler>().scaleFactor = (float)(1 / (2560f / (float) Screen.height));
		}
	}
}
