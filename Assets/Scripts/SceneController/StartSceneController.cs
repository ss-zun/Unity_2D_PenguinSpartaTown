using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public TMP_InputField nameInputField; // �÷��̾� �̸��� �Է¹޴� InputField

    // ���� ������ �̵��ϴ� �޼ҵ�
    public void LoadMainScene()
    {
        // �Է¹��� �÷��̾� �̸��� ����
        string playerName = nameInputField.text;

        if(playerName.Length >=2 && playerName.Length <= 10)
        {
            // PlayerPrefs�� ����Ͽ� �÷��̾� �̸��� ����
            PlayerPrefs.SetString("PlayerName", playerName);

            // ���� ������ �̵�
            SceneManager.LoadScene("MainScene");
        }
    }
}
