using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public TMP_Text playerNameText; // 플레이어 이름

    private void Start()
    {
        // PlayerPrefs에서 플레이어 이름 불러오기
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
