using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWarp : MonoBehaviour
{
    public GameObject Player1;
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
                    print("Ecco la porta numero 1");
                }
            }
        }
    }
}