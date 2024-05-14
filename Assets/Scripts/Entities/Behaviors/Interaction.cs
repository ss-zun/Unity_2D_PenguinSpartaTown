using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NPC ��ó�� ��Ҵ���
/// </summary>
public class Interaction : MonoBehaviour
{
    [SerializeField] private GameObject interactionPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
        {
            interactionPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
        {
            interactionPanel.SetActive(false);
        }
    }
}
