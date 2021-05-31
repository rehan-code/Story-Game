using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;


public class DialogManager : MonoBehaviour
{
    //public Action[] Choices;

    public TextMeshProUGUI dialogue;
    public Button option1;
    public Button option2;
    public Button option3;
    public Button option4;

    public int currentId = 0;

    public Dialogue[] diagList = new Dialogue[10];


    //public void ConstructDialog(Dialog dialog)
    //{
    //    dialog.Choices[0] = () => DestructDialog(dialog);
    //    dialog.Choices[0] += () => "This is a test";

    //}

    //public void DestructDialog(Dialog dialog)
    //{

    //}

    void Start()
    {
        //id 0
        diagList[0].Choices = () =>
        {
            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            option3.gameObject.SetActive(true);
            option4.gameObject.SetActive(false);

            dialogue.text = "what is your favourite colour?";
            option1.GetComponentInChildren<TextMeshProUGUI>().text = "red";
            option2.GetComponentInChildren<TextMeshProUGUI>().text = "yellow";
            option3.GetComponentInChildren<TextMeshProUGUI>().text = "blue";
        };
        diagList[0].childId = new int[] { 1, 2, 3 };
        //id 1 
        diagList[1].Choices = () =>
        {
            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);

            dialogue.text = "why red?";
            option1.GetComponentInChildren<TextMeshProUGUI>().text = "cause I like apples";
            option2.GetComponentInChildren<TextMeshProUGUI>().text = "no reason";
        };
        diagList[1].childId = new int[] { 4, 5 };
        //id 2
        diagList[2].Choices = () =>
        {
            option1.gameObject.SetActive(false);
            option2.gameObject.SetActive(false);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);

            dialogue.text = "yellow like bees";
        };
        diagList[2].childId = null;
        //id 3
        diagList[3].Choices = () =>
        {
            option1.gameObject.SetActive(false);
            option2.gameObject.SetActive(false);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);

            dialogue.text = "blue like the sky";
        };
        diagList[3].childId = null;
        //id 4
        diagList[4].Choices = () =>
        {
            option1.gameObject.SetActive(false);
            option2.gameObject.SetActive(false);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);

            dialogue.text = "apples are great";
        };
        diagList[4].childId = null;
        //id 5
        diagList[5].Choices = () =>
        {
            option1.gameObject.SetActive(false);
            option2.gameObject.SetActive(false);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);

            dialogue.text = "cool beans";
        };
        diagList[5].childId = null;

        //Choices = new Action[4];
        //Choices[0] = () =>
        //{
        //    //set the ones you need to active
        //    option1.gameObject.SetActive(true);
        //    option2.gameObject.SetActive(true);
        //    option3.gameObject.SetActive(true);
        //    option4.gameObject.SetActive(false);

        //    dialogue.text = "option 1 was clicked";
        //    option1.GetComponentInChildren<TextMeshProUGUI>().text = "1: new option 1";
        //    option2.GetComponentInChildren<TextMeshProUGUI>().text = "1: new option 2";
        //    option3.GetComponentInChildren<TextMeshProUGUI>().text = "1: new option 3";
        //    option4.GetComponentInChildren<TextMeshProUGUI>().text = "1: new option 4";
        //};
        //Choices[1] = () =>
        //{
        //    //set the ones you need to active
        //    option1.gameObject.SetActive(true);
        //    option2.gameObject.SetActive(true);
        //    option3.gameObject.SetActive(true);
        //    option4.gameObject.SetActive(true);

        //    dialogue.text = "option 2 was clicked";
        //    option1.GetComponentInChildren<TextMeshProUGUI>().text = "2: new option 1";
        //    option2.GetComponentInChildren<TextMeshProUGUI>().text = "2: new option 2";
        //    option3.GetComponentInChildren<TextMeshProUGUI>().text = "2: new option 3";
        //    option4.GetComponentInChildren<TextMeshProUGUI>().text = "2: new option 4";
        //};
        //Choices[2] = () =>
        //{
        //    dialogue.text = "option 3 was clicked";
        //    option1.GetComponentInChildren<TextMeshProUGUI>().text = "3: new option 1";
        //    option2.GetComponentInChildren<TextMeshProUGUI>().text = "3: new option 2";
        //    option3.GetComponentInChildren<TextMeshProUGUI>().text = "3: new option 3";
        //    option4.GetComponentInChildren<TextMeshProUGUI>().text = "3: new option 4";
        //};
        //Choices[3] = () =>
        //{
        //    dialogue.text = "option 4 was clicked";
        //    option1.GetComponentInChildren<TextMeshProUGUI>().text = "4: new option 1";
        //    option2.GetComponentInChildren<TextMeshProUGUI>().text = "4: new option 2";
        //    option3.GetComponentInChildren<TextMeshProUGUI>().text = "4: new option 3";
        //    option4.GetComponentInChildren<TextMeshProUGUI>().text = "4: new option 4";
        //};

        option1.onClick.AddListener(() => ButtonEvent(option1.transform.GetSiblingIndex()));
        option2.onClick.AddListener(() => ButtonEvent(option2.transform.GetSiblingIndex()));
        option3.onClick.AddListener(() => ButtonEvent(option3.transform.GetSiblingIndex()));
        option4.onClick.AddListener(() => ButtonEvent(option4.transform.GetSiblingIndex()));
        
        diagList[0].Choices();
    }

    public void ButtonEvent(int index)
    {
        currentId = diagList[currentId].childId[index];
        diagList[currentId].Choices();
        //Choices[index]();

        //dialogue.text = "this is a test 1";
        //option1.text = "new option 1";
        //option2.text = "new option 2";
        //option3.text = "new option 3";
        //Debug.Log("Clicked");

        //option4.SetActive(false);
    }
}
