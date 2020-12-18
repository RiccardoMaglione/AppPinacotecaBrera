using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockOutSound : MonoBehaviour
{
    [SerializeField]
    public string Suono;

    [SerializeField]
    public string SuonoOFF;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("BlockOut") == 1)
        {
            AudioManager.instance.Play(Suono);
            AudioManager.instance.Stop(SuonoOFF);
            PlayerPrefs.SetInt("BlockOut", 0);
        }
        
    }
}
