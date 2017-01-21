using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebLink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void LinkToWeb(string link) {

		Application.OpenURL(link);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
