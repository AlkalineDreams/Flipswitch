using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
    
	}
	
    public void ChangeTheScene(string sceneName)
    {
        //sceneName is the scene you want to change to
        

        Application.LoadLevel(sceneName);

    }
	// Update is called once per frame
	void Update () {
		
	}
}
