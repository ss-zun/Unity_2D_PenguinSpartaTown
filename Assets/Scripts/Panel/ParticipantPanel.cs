using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 인게임에서 참석자 패널
/// </summary>
public class ParticipantPanel : MonoBehaviour
{
    [SerializeField] private GameObject participantPanel;
    [SerializeField] private List<string> NameTextList = new List<string>();
    [SerializeField] private TMP_Text participantList;
    public void EnableParticipantPanel()
    {
        participantPanel.SetActive(true);
    }

    public void DisableParticipantPanel()
    {
        participantPanel.SetActive(false);
    }

    public void SetNameTextList(TMP_Text playerName)
    {
        string Temp = "";
        foreach (var Name in NameTextList)
        {
            Temp += Name + "\n";
        }
        Temp += playerName.text + "\n";
        participantList.text = Temp;
    }
}
