using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCameraGameplay : MonoBehaviour
{
    public GameObject[] PlayerSpot;

    void Update()
    {
        if(MapWarp.Warp1 == true)
        {
            MapWarp.Warp1 = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[0].SetActive(true);
        }
        if (MapWarp.Warp2 == true)
        {
            MapWarp.Warp2 = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[1].SetActive(true);
        }
        if (MapWarp.Warp3 == true)
        {
            MapWarp.Warp3 = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[2].SetActive(true);
        }
    }
}
