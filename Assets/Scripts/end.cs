using System.Collections;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public bool crown_collected;
    void Start()
    {
        crown_collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (crown_collected) 
        {
            StartCoroutine(toOutro());
            crown_collected=false;
        }
    }


    IEnumerator toOutro()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("OUTRO");
    }
}
