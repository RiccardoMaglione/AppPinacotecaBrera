using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveBadge : MonoBehaviour
{
    public void DeActiveB()
    {
        PlayerPrefs.SetInt("PuzzleImage", 1);
    }
}
