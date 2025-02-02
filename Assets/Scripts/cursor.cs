using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI NewGamee;
    [SerializeField]
    public TextMeshProUGUI Settings;
    [SerializeField]
    public TextMeshProUGUI Credits;
    [SerializeField]
    public TextMeshProUGUI Quit;

    public Texture2D cursorTexture;
    public Vector2 hotspot = Vector2.zero;
    private Color defaultColor = Color.white;
    private Color hoverColor = Color.grey;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
    }

    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadSceneAsync("WSTEP");
    }

    //NEW GAME

    public void HoverOn()
    {
        NewGamee.color = hoverColor;
    }

    public void HoverOff()
    {
        NewGamee.color = defaultColor;
    }


    //CREDITS

    public void HoverOnCredits()
    {
        Credits.color = hoverColor;
    }

    public void HoverOffCredits()
    {
        Credits.color = defaultColor;
    }

    //QUIT

    public void HoverOnQuit()
    {
        Quit.color = hoverColor;
    }

    public void HoverOffQuit()
    {
        Quit.color = defaultColor;
    }
}
