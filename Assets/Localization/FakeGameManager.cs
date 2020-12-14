using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGameManager : MonoBehaviour
{
    // The game manager must be have priority execution order as first class executed from Unity
    // Initialize the LOCALIZATION MANGER during resource loading procedure
    // Otherwise try to create and initialize it before RUNTIME-UI initialization
    //
    public Localization.LocalizationManager localizationManager;
    public static FakeGameManager singleton;

    /* UNITY CALLBACKS */
    private void Awake()
    {
        if (!singleton) singleton = this;
    }

    void Start()
    {
        /* CREATE & INTIALIZE LOCALIZATION RESOURCES */
        localizationManager = new Localization.LocalizationManager();
        localizationManager.Initialize(Localization.LocalizationManager.ELanguage.ITA);  // NOW ALL UI ARE LOCALIZATED :)
        
    }
}
