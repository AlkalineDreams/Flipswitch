using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Thread.Sleep(1000);
        //Application.LoadLevel("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
        Thread.Sleep(1000);
        Application.LoadLevel("MainMenu");
    }
}
