using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplaySelectPanel : MonoBehaviour
{
    public GameObject selectPanel;
    public GameObject joinPanel;
    public GameObject selectImg;

    public void EnableSelectPanel()
    {
        selectPanel.SetActive(true);
        if (!GameManager.instance.isPlay)
        {
            joinPanel.SetActive(false);
            selectImg.SetActive(false);
        }  
    }

    public void DisableSelectPanel()
    {
        selectPanel.SetActive(false);
        if (!GameManager.instance.isPlay)
        {
            joinPanel.SetActive(true);
            selectImg.SetActive(true);
        }       
    }
}
