using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParticipantPanel : MonoBehaviour
{
    public GameObject participantPanel;
    public List<string> NameTextList = new List<string>();
    public TMP_Text participantList;
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
