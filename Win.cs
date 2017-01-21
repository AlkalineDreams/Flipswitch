using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public IEnumerable WaitForTheSeconds ()
    {
        yield return new WaitForSeconds(5);
        
    }

    public static void delay ()
    {
        DateTime dt = DateTime.Now + TimeSpan.FromSeconds(5);

        do { } while (DateTime.Now < dt);

    }

    public void DidYouWinYet(string button1)
    {

        if (GameObject.Find(button1).GetComponent<Image>().sprite == Resources.Load<Sprite>("button_on"))
        {

            if (PlayerPrefs.GetInt("highestLevel") > 2)
            {

            } else
            {
                PlayerPrefs.SetInt("highestLevel", 2);
            }

            //delay();
            //DateTime dt = DateTime.Now + TimeSpan.FromSeconds(5);

            //do { } while (DateTime.Now < dt);

            Application.LoadLevel("LevelTwo");

        }

    }

 
    // Update is called once per frame
    void Update()
    {



    }

   
}

