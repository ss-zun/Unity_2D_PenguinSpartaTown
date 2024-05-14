using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 게임시작 전 선택한 캐릭터 이미지 표시
/// </summary>
public class DisplaySelectCharacter : MonoBehaviour
{
    [SerializeField] private Sprite[] character;
    private Image selectCharacter;

    private void Awake()
    {
        selectCharacter = GetComponent<Image>();
    }

    public void ChangeSelectImg()
    {
        selectCharacter.sprite = character[GameManager.instance.playerType];
    }
}
