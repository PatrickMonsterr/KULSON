using UnityEngine;

public class Save_Load : MonoBehaviour
{
    public Transform player;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SaveGame()
    {
        PlayerPrefs.SetFloat("X", player.position.x);
        PlayerPrefs.SetFloat("Y", player.position.y);
        PlayerPrefs.SetFloat("Z", player.position.z);
        PlayerPrefs.Save();
        Debug.Log("zapis udany");
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("X")) // Sprawdza, czy istnieje zapis
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");

            player.position = new Vector3(x, y, z);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kula"))
        {
            SaveGame();
        }
    }
}
