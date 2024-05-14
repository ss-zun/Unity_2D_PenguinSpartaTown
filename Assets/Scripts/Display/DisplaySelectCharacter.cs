using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySelectCharacter : MonoBehaviour
{
    public Sprite[] character;
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
