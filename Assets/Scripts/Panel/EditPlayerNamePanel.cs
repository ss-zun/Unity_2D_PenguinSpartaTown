using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// �ΰ��ӿ��� �÷��̾� �̸� ���� �г�
/// </summary>
public class EditPlayerNamePanel : MonoBehaviour
{
    [SerializeField] private GameObject editPlayerNamePanel;
    [SerializeField] private TMP_InputField editInputField; // �÷��̾� �̸� ����
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
