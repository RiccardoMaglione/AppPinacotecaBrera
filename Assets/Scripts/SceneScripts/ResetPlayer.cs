using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ResetPlayer : MonoBehaviour
{
    [MenuItem("Edit/Reset Peppino")]
    static void ResetPrefs()
    {
        PlayerPrefs.SetString("Nickname", "Player's Name");
        PlayerPrefs.SetInt("NicknameControl", 0);
        PlayerPrefs.SetInt("Luca", 0);
        PlayerPrefs.SetInt("Puzzle", 0);
        PlayerPrefs.SetInt("Light", 0);
        PlayerPrefs.SetInt("PuzzleCompleted", 0);
        PlayerPrefs.SetInt("Ring", 0);
        PlayerPrefs.SetInt("LightDoor", 0);
    }
}