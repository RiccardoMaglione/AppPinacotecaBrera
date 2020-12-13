using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeManager : MonoBehaviour
{

    public CamShake1 Myscript;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 0) || gameObject.transform.rotation == Quaternion.Euler(0, 0, 360))
        {

            StartCoroutine(StopCo());

        }
        else
        {
            Myscript.enabled = true;
        }
    }

    IEnumerator StopCo()
    {
        yield return new WaitForSeconds(1f);
        Myscript.enabled = false;
    }
}
