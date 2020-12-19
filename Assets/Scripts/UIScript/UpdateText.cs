using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public string StringNameUpdate;
    public Text TextNameUpdate;
    void Update()
    {
        StringNameUpdate = PlayerPrefs.GetString("Nickname");
        TextNameUpdate.text = StringNameUpdate;
    }
}
