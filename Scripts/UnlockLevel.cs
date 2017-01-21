using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockLevel : MonoBehaviour {

    // private var lock1 : GameObject;
    GameObject lock2;
    // Use this for initialization
    void Start () {

        if (PlayerPrefs.HasKey("highestLevel"))
        {
            

        } else {

            PlayerPrefs.SetInt("highestLevel", 1);

        }

       GameObject lock2 = GameObject.Find("2");

        GameObject.Find("2").GetComponent<Button>().interactable = false;
        GameObject.Find("3").GetComponent<Button>().interactable = false;
        GameObject.Find("4").GetComponent<Button>().interactable = false;
        GameObject.Find("5").GetComponent<Button>().interactable = false;
        GameObject.Find("6").GetComponent<Button>().interactable = false;
        GameObject.Find("7").GetComponent<Button>().interactable = false;
        GameObject.Find("8").GetComponent<Button>().interactable = false;
        GameObject.Find("9").GetComponent<Button>().interactable = false;
        GameObject.Find("10").GetComponent<Button>().interactable = false;
        GameObject.Find("11").GetComponent<Button>().interactable = false;
        GameObject.Find("12").GetComponent<Button>().interactable = false;
        GameObject.Find("13").GetComponent<Button>().interactable = false;
        GameObject.Find("14").GetComponent<Button>().interactable = false;
        GameObject.Find("15").GetComponent<Button>().interactable = false;

        /* for (int counter = 1; counter <= PlayerPrefs.GetInt("highestLevel"); counter++)
         {

              string temp = counter.ToString();

              GameObject.Find(temp).GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
              GameObject.Find(temp).GetComponentInChildren<Text>().text = temp;
              GameObject.Find(temp).GetComponent<Button>().interactable = true;

          }*/

        //ADD AN IF STATEMENT FOR EVERY SINGLE LEVEL BUTTON

        if (PlayerPrefs.GetInt("highestLevel") >= 1)
        {

            GameObject.Find("1").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("1").GetComponentInChildren<Text>().text = "1";
            GameObject.Find("1").GetComponent<Button>().interactable = true;

        }

        if (PlayerPrefs.GetInt("highestLevel") >= 2)
        {

            GameObject.Find("2").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("2").GetComponentInChildren<Text>().text = "2";
            GameObject.Find("2").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 3)
        {

            GameObject.Find("3").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("3").GetComponentInChildren<Text>().text = "3";
            GameObject.Find("3").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 4)
        {

            GameObject.Find("4").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("4").GetComponentInChildren<Text>().text = "4";
            GameObject.Find("4").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 5)
        {

            GameObject.Find("5").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("5").GetComponentInChildren<Text>().text = "5";
            GameObject.Find("5").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 6)
        {

            GameObject.Find("6").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("6").GetComponentInChildren<Text>().text = "6";
            GameObject.Find("6").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 7)
        {

            GameObject.Find("7").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("7").GetComponentInChildren<Text>().text = "7";
            GameObject.Find("7").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 8)
        {

            GameObject.Find("8").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("8").GetComponentInChildren<Text>().text = "8";
            GameObject.Find("8").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 9)
        {

            GameObject.Find("9").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("9").GetComponentInChildren<Text>().text = "9";
            GameObject.Find("9").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 10)
        {

            GameObject.Find("10").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("10").GetComponentInChildren<Text>().text = "10";
            GameObject.Find("10").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 11)
        {

            GameObject.Find("11").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("11").GetComponentInChildren<Text>().text = "11";
            GameObject.Find("11").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 12)
        {

            GameObject.Find("12").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("12").GetComponentInChildren<Text>().text = "12";
            GameObject.Find("12").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 13)
        {

            GameObject.Find("13").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("13").GetComponentInChildren<Text>().text = "13";
            GameObject.Find("13").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 14)
        {

            GameObject.Find("14").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("14").GetComponentInChildren<Text>().text = "14";
            GameObject.Find("14").GetComponent<Button>().interactable = true;

        }
        if (PlayerPrefs.GetInt("highestLevel") >= 15)
        {

            GameObject.Find("15").GetComponent<Image>().sprite = Resources.Load<Sprite>("levelselectbutton-outline");
            GameObject.Find("15").GetComponentInChildren<Text>().text = "15";
            GameObject.Find("15").GetComponent<Button>().interactable = true;

        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
