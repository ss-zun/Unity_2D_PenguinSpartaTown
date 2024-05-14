using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���ӽ��� �� ������ ĳ���� �̹��� ǥ��
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
