using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI NewGamee;
    [SerializeField]
    public TextMeshProUGUI Continue;
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

    private Transform PlayerTr;

    void Awake()
    {
        settingsy.enabled = false;
        menu.enabled = true;
        Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
        LoadSound();
        DontDestroyOnLoad(gameObject);
    }

    //void Start()
    //{
    //    settingsy.enabled = false;
    //    menu.enabled = true;
    //    Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
    //    LoadSound();
    //    DontDestroyOnLoad(gameObject);
    //}

    public void Continuee()
    {
        StartCoroutine(LoadGameWithDelay());
    }

    public void NewGame()
    {
        SceneManager.LoadSceneAsync("WSTEP");
    }

    public void Settings_button()
    {
        menu.enabled = false;
        settingsy.enabled = true;
    }

    public void BackButton()
    {
        settingsy.enabled = false;
        menu.enabled = true;
    }

    public void QuitButton()
    {
        Application.Quit(); 
    }

    public void SaveSound()
    {
        PlayerPrefs.SetFloat("Music", MusicSlider.value);
        PlayerPrefs.SetFloat("SoundEffects", SoundEffectsSlider.value);
        PlayerPrefs.Save();
        LoadSound();
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

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("X"))
        {
            float x = PlayerPrefs.GetFloat("X");
            float y = PlayerPrefs.GetFloat("Y");
            float z = PlayerPrefs.GetFloat("Z");

            if (PlayerTr != null)
            {
                PlayerTr.position = new Vector3(x, y, z);
                Debug.Log($"Pozycja gracza załadowana: {x}, {y}, {z}");
            }
            else
            {
                Debug.LogError("Błąd: Transform gracza nie został znaleziony!");
            }
        }
        else
        {
            Debug.LogWarning("Brak zapisanej pozycji gracza w PlayerPrefs.");
        }
    }

    IEnumerator LoadGameWithDelay()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GRA");
        yield return new WaitUntil(() => asyncLoad.isDone);

        GameObject player = GameObject.Find("Kula");

        if (player != null)
        {
            PlayerTr = player.transform;
            Debug.Log("Znaleziono obiekt 'Kula', wczytywanie pozycji...");
            LoadGame();
        }
        else
        {
            Debug.LogError("Błąd: Obiekt 'Kula' nie został znaleziony w nowej scenie!");
        }
    }

}
