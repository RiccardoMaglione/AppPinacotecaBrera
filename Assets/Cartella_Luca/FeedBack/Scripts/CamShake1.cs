using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake1 : MonoBehaviour
{
    
   
    public Camera cam;


    IEnumerator Shake(float duration, float magnitude)
    {
        
        
            Vector3 originalpose = cam.transform.localPosition;

            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                float x = Random.Range(2, -2) * magnitude;
                float y = Random.Range(2, -2) * magnitude;

                cam.transform.localPosition = new Vector3(x, y, originalpose.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            cam.transform.position = originalpose;
        

    }

    private void Update()
    {
        CamShake();
    }

    void CamShake()
    {
        if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 0) || gameObject.transform.rotation == Quaternion.Euler(0, 0, 360))
        {
            StartCoroutine(Shake(1f, 3f));                               
        }
       
    }

}