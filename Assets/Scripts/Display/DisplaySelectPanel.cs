using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 인게임에서 캐릭터 선택 패널 끄고 켜기
/// </summary>
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
