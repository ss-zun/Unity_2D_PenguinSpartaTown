using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditPlayerNamePanel : MonoBehaviour
{
    public GameObject editPlayerNamePanel;
    public TMP_InputField editInputField; // 플레이어 이름 수정
    public void ChangePlayerName()
    {
        GameManager.instance.playerName.text = editInputField.text;
    }

    public void EnableEditPlayerName()
    {
        editPlayerNamePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void DisableEditPlayerName()
    {
        editPlayerNamePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
