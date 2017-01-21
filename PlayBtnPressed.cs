using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBtnPressed : MonoBehaviour {

    Sprite PlayButton_pressed;
    Sprite AboutButton_pressed;
    Sprite HelpButton_pressed; 

	// Use this for initialization
	void Start () {

      PlayButton_pressed = Resources.Load<Sprite>("playbutton-inverted");
      AboutButton_pressed = Resources.Load<Sprite>("aboutbutton-inverted");
      HelpButton_pressed = Resources.Load<Sprite>("helpbutton-inverted");

    }

	public void ChangeTheImage (string buttonName) {

        if (buttonName == "PlayButton")
        {

            GameObject.Find(buttonName).GetComponent<Image>().sprite = PlayButton_pressed;
            Application.LoadLevel("LevelSelect");

        } else if (buttonName == "HelpButton"){

            GameObject.Find(buttonName).GetComponent<Image>().sprite = HelpButton_pressed;
            Application.LoadLevel("Help");

        } else if (buttonName == "AboutButton") {

            GameObject.Find(buttonName).GetComponent<Image>().sprite = AboutButton_pressed;
            Application.LoadLevel("About");

        } else
        {
        }

	}
	// Update is called once per frame
	void Update () {
		
	}
}
