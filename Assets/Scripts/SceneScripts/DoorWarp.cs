﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorWarp : MonoBehaviour
{
    public GameObject[] PlayerArray;
    public GameObject Marriage;

    RaycastHit hit;
    Ray ray;

    bool CanWarp = true;

    void Update()
    {
        if((Input.GetMouseButtonDown(0) || Input.touchCount == 1) && CanWarp == true)
        {
            WarpDoor();
        }
        else if ((Input.GetMouseButtonUp(0) || Input.touchCount == 0) && CanWarp == false)
        {
            CanWarp = true;
        }
    }

    public void WarpDoor()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                if (hit.collider.name == "Door1")
                {
                    AudioManager.instance.Play("Movimento");
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[0].SetActive(true);
                }
                if (hit.collider.name == "Door2")
                {
                    AudioManager.instance.Play("Movimento");
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[1].SetActive(true);
                }
                if (hit.collider.name == "Door3")
                {
                    AudioManager.instance.Play("Movimento");
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[2].SetActive(true);
                }
                if (hit.collider.name == "SPOSALIZIO")
                {
                    SceneManager.LoadScene("RingMinigameTest");
                }
                if (hit.collider.name == "Il Bacio")
                {
                    SceneManager.LoadScene("DEMO");
                }
                if (hit.collider.name == "Cube (17)")
                {
                    SceneManager.LoadScene("LightMGScene");
                }
            }
        }
        CanWarp = false;
    }
}