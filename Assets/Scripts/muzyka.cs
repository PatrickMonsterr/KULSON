using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class muzyka : MonoBehaviour
{
    public AudioSource music;
    public float fadeDuration = 3f;
    public AudioSource muzykaGra;
    void Start()
    {
        music.volume = 0; // Start od 0 głośności
        music.Play();
        
        LoadSound();
        //StartCoroutine(Fadein());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator Fadein()
    //{
    //    float startVolume = 0f;

    //    while (music.volume < 1f)
    //    {
    //        startVolume += Time.deltaTime / fadeDuration;
    //        music.volume = Mathf.Clamp01(startVolume);
    //        yield return null;
    //    }
    //}
    public void LoadSound()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            Debug.Log("Wczytywanie w grze dziala");
            float music = PlayerPrefs.GetFloat("Music");
            float soundEffects = PlayerPrefs.GetFloat("SoundEffects");

            muzykaGra.volume = music;

        }
        else
        {
            muzykaGra.volume = 1f;
        }
    }
}
