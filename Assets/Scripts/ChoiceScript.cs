using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption1 () {
        TextBox.GetComponent<Text>().text = "Nah, I’ll help. It’ll be quicker with two people, and your mom will kill me if you get detention.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2 () {
        TextBox.GetComponent<Text>().text = "For a second there I thought you’d say no. Sweet. You check that side and I’ll check over here.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3 () {
        TextBox.GetComponent<Text>().text = "Well that’s just rude.";
        ChoiceMade = 3;
    }

    void Update () {
        if(ChoiceMade > 1) {
            Choice01.SetActive (false);
            Choice02.SetActive (false);
            Choice03.SetActive (false);
        }
    }


}
