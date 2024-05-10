using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public TMP_Text playerNameText; // �÷��̾� �̸�

    private void Start()
    {
        // PlayerPrefs���� �÷��̾� �̸� �ҷ�����
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
