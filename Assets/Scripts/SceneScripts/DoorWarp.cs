using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWarp : MonoBehaviour
{
    public GameObject[] PlayerArray;

    RaycastHit hit;
    Ray ray;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.touchCount == 1)
        {
            WarpDoor();
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
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[0].SetActive(true);
                }
                if (hit.collider.name == "Door2")
                {
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[1].SetActive(true);
                }
                if (hit.collider.name == "Door3")
                {
                    for (int i = 0; i < PlayerArray.Length; i++)
                    {
                        PlayerArray[i].SetActive(false);
                    }
                    PlayerArray[2].SetActive(true);
                }
            }
        }
    }
}