﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      AudioManager.instance.Play("EndMinigame");
        Debug.Log("HideoKojima");
    }
}
