using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void turnOffButton(string buttonName)
    {
        GameObject thisButton = GameObject.Find(buttonName);

        thisButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("button_off");

    }
	// Update is called once per frame
	void Update () {
		
	}
}
