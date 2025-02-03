using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI NewGamee;
    [SerializeField]
    public TextMeshProUGUI Settings;
    [SerializeField]
    public TextMeshProUGUI Quit;
    [SerializeField]
    public Canvas settingsy;
    public Canvas menu;
    public TextMeshProUGUI Back;
    public AudioSource muzykaMenu;

    public Slider MusicSlider;
    public Slider SoundEffectsSlider;

    public Texture2D cursorTexture;
    public Vector2 hotspot = Vector2.zero;
    private Color defaultColor = Color.white;
    private Color hoverColor = Color.grey;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
        LoadSound();
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


 

    
    //QUIT

    public void HoverOnQuit()
    {
        Quit.color = hoverColor;
    }

    public void HoverOffQuit()
    {
        Quit.color = defaultColor;
    }
    public void HoverOnSettings()
    {
        Settings.color = hoverColor;
    }

    public void HoverOffSettings()
    {
        Settings.color = defaultColor;
    }

    public void Settings_button()
    {
        menu.enabled = false;
        settingsy.enabled = true;
    }
    public void HoverOnBack()
    {
        Back.color = hoverColor;
    }

    public void HoverOffBack()
    {
        Back.color = defaultColor;
    }
    public void BackButton()
    {
        settingsy.enabled = false;
        menu.enabled = true;
    }


    //SOUND MANAGER
    public void SaveSound()
    {
        PlayerPrefs.SetFloat("Music", MusicSlider.value);
        PlayerPrefs.SetFloat("SoundEffects", SoundEffectsSlider.value);
        PlayerPrefs.Save();
        LoadSound();
        Debug.Log("zapis udany");
    }


    public void LoadSound()
    {
        if (PlayerPrefs.HasKey("Music")) 
        {
            float music = PlayerPrefs.GetFloat("Music");
            float soundEffects = PlayerPrefs.GetFloat("SoundEffects");

            MusicSlider.value = music;
            SoundEffectsSlider.value = soundEffects;

            muzykaMenu.volume = music;

        }
        else
        {
            MusicSlider.value = 1f;
            SoundEffectsSlider.value = 1f;
        }
    }




}
