using UnityEngine;

public class music_dontdestroy : MonoBehaviour
{
    private static music_dontdestroy instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
}
