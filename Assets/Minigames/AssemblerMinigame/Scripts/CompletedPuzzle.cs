using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedPuzzle : MonoBehaviour
{
    public GameObject[] DeactiveObject;
    public GameObject PanelBadge;
    void Update()
    {
        if(PlayerPrefs.GetInt("PuzzleCompleted") == 1)
        {
            for (int i = 0; i < DeactiveObject.Length; i++)
            {
                DeactiveObject[i].SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("PuzzleImage") == 1)
        {
            PanelBadge.SetActive(false);
        }
    }
}
