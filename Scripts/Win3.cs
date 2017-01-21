using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

// script to check for a win on any level with 3 buttons. 

public class Win3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

   

    public void DidYouWinYet(int levelToChangeTo)
    {

        GameObject b1 = GameObject.Find("1");
        GameObject b2 = GameObject.Find("2");
        GameObject b3 = GameObject.Find("3");

        if (b1.GetComponent<Image>().sprite == Resources.Load<Sprite>("button_on") && b2.GetComponent<Image>().sprite == Resources.Load<Sprite>("button_on") && b3.GetComponent<Image>().sprite == Resources.Load<Sprite>("button_on"))
        {

            //sets the playerprefs highestlevel if you havent been past this point before to unlock the next level on the level select  
            if (PlayerPrefs.GetInt("highestLevel") > levelToChangeTo)
            {

            }
            else
            {
                PlayerPrefs.SetInt("highestLevel",levelToChangeTo);
            }

            Thread.Sleep(200);

            Application.LoadLevel(levelToChangeTo.ToString());
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
