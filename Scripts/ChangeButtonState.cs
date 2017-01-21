using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ChangeButtonState : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
    public void ChangeTheState(string buttonName)
    {
        GameObject thisButton = GameObject.Find(buttonName);

        if (thisButton.GetComponent<Image> ().sprite == Resources.Load<Sprite>("button_off")) {

            thisButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("button_on");
            

        }
        else {

            thisButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("button_off");
            

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
