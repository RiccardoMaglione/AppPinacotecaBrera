using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorWarp : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    void Update()
    {
        WarpDoor();
    }

    public void WarpDoor()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                if (hit.collider.name == "Door1")
                {
                    MapWarp.Warp1 = true;
                    MapWarp.Warp2 = false;
                    MapWarp.Warp3 = false;
                    Player1.SetActive(true);
                    Player2.SetActive(false);
                    Player3.SetActive(false);
                }
                if (hit.collider.name == "Door2")
                {
                    MapWarp.Warp1 = false;
                    MapWarp.Warp2 = true;
                    MapWarp.Warp3 = false;
                    Player1.SetActive(false);
                    Player2.SetActive(true);
                    Player3.SetActive(false);
                }
                if (hit.collider.name == "Door3")
                {
                    MapWarp.Warp1 = false;
                    MapWarp.Warp2 = false;
                    MapWarp.Warp3 = true;
                    Player1.SetActive(false);
                    Player2.SetActive(false);
                    Player3.SetActive(true);
                }
            }
        }
    }
}
