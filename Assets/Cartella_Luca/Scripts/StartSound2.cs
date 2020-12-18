using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound2 : MonoBehaviour
{
    [SerializeField]
    public string Suono;

    [SerializeField]
    public string SuonoOFF;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.Play(Suono);
        AudioManager.instance.Stop(SuonoOFF);
    }

   
}
