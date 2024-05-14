using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NPC¿Í ´ëÈ­
/// </summary>
public class NPCInteractionPanel : MonoBehaviour
{
    [SerializeField] private GameObject interactionPanel;
    [SerializeField] private GameObject chatPanel;

    public void EnableChatPanel()
    {
        chatPanel.SetActive(true);
        interactionPanel.SetActive(false);
    }

    public void DisableChatPanel()
    {
        chatPanel.SetActive(false);
    }
}
