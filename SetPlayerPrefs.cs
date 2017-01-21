using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
        if (PlayerPrefs.GetInt("highestLevel") < 2)
        {
            PlayerPrefs.SetInt("highestLevel", 2);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
