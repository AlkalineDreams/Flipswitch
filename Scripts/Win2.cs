using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class Win2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void DidYouWinYet(string levelToChangeTo)
    {

        GameObject b1 = GameObject.Find("01");
        GameObject b2 = GameObject.Find("02");

        if (b1.GetComponent<Image> ().sprite == Resources.Load<Sprite>("button_on") && b2.GetComponent<Image>().sprite == Resources.Load<Sprite>("button_on"))
        {
            //sets the playerprefs highestlevel if you havent been past this point before to unlock the next level on the level select
            if (PlayerPrefs.GetInt("highestLevel") > 3)
            {

            } else
            {
                PlayerPrefs.SetInt("highestLevel", 3);
            }
            Thread.Sleep(200);
            
            Application.LoadLevel(levelToChangeTo);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
