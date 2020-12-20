using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveBadge : MonoBehaviour
{
    public GameObject BadgePanel;
    public void DeActiveB()
    {
        BadgePanel.SetActive(false);
        PlayerPrefs.SetInt("PuzzleImage", 1);
    }
}
