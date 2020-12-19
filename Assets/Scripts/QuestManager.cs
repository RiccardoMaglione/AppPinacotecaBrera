using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("Quest") >= 3)
        {
            //quest completed
        }
    }
}
