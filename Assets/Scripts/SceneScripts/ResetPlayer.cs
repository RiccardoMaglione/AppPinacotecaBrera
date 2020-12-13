using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ResetPlayer : MonoBehaviour
{
    [MenuItem("Edit/Reset Peppino")]
    static void ResetPrefs()
    {
        PlayerPrefs.SetInt("Luca", 0);
        PlayerPrefs.SetInt("Puzzle", 0);
        PlayerPrefs.SetInt("Light", 0);
    }
}
