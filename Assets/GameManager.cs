using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject inGame;
    public GameObject joinPanel;
    public TMP_InputField nameInputField; // 입력받은 플레이어 이름
    public TMP_Text playerName;
    public TMP_Text timeText;
    public Animator animator;
    public RuntimeAnimatorController[] controller;

    public int playerType;
    public bool isPlay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }        
    }

    private void Start()
    {
        Time.timeScale = 0.0f;
    }

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    public void GameStart()
    {
        playerName.text = nameInputField.text;
        if (playerName.text.Length >= 2 && playerName.text.Length <= 10)
        {
            isPlay = true;
            inGame.SetActive(true);
            joinPanel.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void SelectCharacter(int type)
    {
        playerType = type;
        animator.runtimeAnimatorController = controller[playerType];
    }
}
