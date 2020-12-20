using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject NamePanel;
    public InputField TextName;
    string Name;
    void Start()
    {
        if (PlayerPrefs.GetInt("NicknameControl") == 1)
        {
            MenuPanel.SetActive(true);
            NamePanel.SetActive(false);
        }
    }

    public void RegisterName()
    {
        if (PlayerPrefs.GetInt("NicknameControl") == 0)
        {
            PlayerPrefs.SetString("Nickname", TextName.text.ToString());
            print(PlayerPrefs.GetString("Nickname"));
            PlayerPrefs.SetInt("NicknameControl", 1);
            MenuPanel.SetActive(true);
            NamePanel.SetActive(false);
            PlayerPrefs.SetInt("FirstBadge", 1);
        }
    }
}
