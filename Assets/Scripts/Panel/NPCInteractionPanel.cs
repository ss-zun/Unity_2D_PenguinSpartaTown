using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractionPanel : MonoBehaviour
{
    public GameObject interactionPanel;
    public GameObject chatPanel;

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
