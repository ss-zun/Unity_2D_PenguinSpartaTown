using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public TMP_InputField nameInputField; // 플레이어 이름을 입력받는 InputField

    // 다음 씬으로 이동하는 메소드
    public void LoadMainScene()
    {
        // 입력받은 플레이어 이름을 저장
        string playerName = nameInputField.text;

        if(playerName.Length >=2 && playerName.Length <= 10)
        {
            // PlayerPrefs를 사용하여 플레이어 이름을 저장
            PlayerPrefs.SetString("PlayerName", playerName);

            // 메인 씬으로 이동
            SceneManager.LoadScene("MainScene");
        }
    }
}
