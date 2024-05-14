using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 인게임에서 플레이어 이름 변경 패널
/// </summary>
public class EditPlayerNamePanel : MonoBehaviour
{
    [SerializeField] private GameObject editPlayerNamePanel;
    [SerializeField] private TMP_InputField editInputField; // 플레이어 이름 수정
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
