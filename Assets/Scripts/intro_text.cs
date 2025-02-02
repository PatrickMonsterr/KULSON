using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro_text : MonoBehaviour
{
    public TextMeshProUGUI intro;
    void Start()
    {
        StartCoroutine(DisplayText());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(3f);
        intro.text = "Hi.";  
        yield return new WaitForSeconds(4f);
        intro.text = "The story is simple.";
        yield return new WaitForSeconds(4f);
        intro.text = "You are a ball and your name is Bul.";
        yield return new WaitForSeconds(4f);
        intro.text = "You have been exiled from the ball empire by your father, the king who is called Kul";
        yield return new WaitForSeconds(4f);
        intro.text = "so you are Kul son";
        yield return new WaitForSeconds(4f);
        intro.text = "Now you have to escape the dungeon and kill you father";
        yield return new WaitForSeconds(4f);
        intro.text = "Good luck";

        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync("GRA");





    }
}
