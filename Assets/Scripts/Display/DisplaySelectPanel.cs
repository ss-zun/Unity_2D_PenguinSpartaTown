using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// �ΰ��ӿ��� ĳ���� ���� �г� ���� �ѱ�
/// </summary>
public class DisplaySelectPanel : MonoBehaviour
{
    [SerializeField] private GameObject selectPanel;
    [SerializeField] private GameObject joinPanel;
    [SerializeField] private GameObject selectImg;

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
