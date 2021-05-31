using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject inventoryButton;
    public GameObject statsButton;
    public GameObject settingsButton;
    public GameObject mMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        inventoryButton.SetActive(false);
        statsButton.SetActive(false);
        settingsButton.SetActive(false);
        mMenuButton.SetActive(false);
    }

    public void onClick()
    {
        if (inventoryButton.activeSelf == true)
        {
            inventoryButton.SetActive(false);
            statsButton.SetActive(false);
            settingsButton.SetActive(false);
            mMenuButton.SetActive(false);
        } else
        {
            inventoryButton.SetActive(true);
            statsButton.SetActive(true);
            settingsButton.SetActive(true);
            mMenuButton.SetActive(true);
        }
    }
}
