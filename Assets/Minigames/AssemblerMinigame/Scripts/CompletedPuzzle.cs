using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedPuzzle : MonoBehaviour
{
    public GameObject[] DeactiveObject;
    void Update()
    {
        if(PlayerPrefs.GetInt("PuzzleCompleted") == 1)
        {
            for (int i = 0; i < DeactiveObject.Length; i++)
            {
                DeactiveObject[i].SetActive(false);
            }
        }
    }
}
