using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Late());
    }

    IEnumerator Late()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
