using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject inGame;
    [SerializeField] private GameObject joinPanel;
    [SerializeField] private TMP_InputField nameInputField; // 입력받은 플레이어 이름
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private Animator animator;
    [SerializeField] private RuntimeAnimatorController[] controller;

    public TMP_Text playerName;

    public int playerType { get; private set; }
    public bool isPlay { get; private set; }

    private void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this; 
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
