using UnityEngine;

public class environmentchange : MonoBehaviour
{
    public Material skybox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
   {
    if(collision.gameObject.CompareTag("Kula"))
    {
       RenderSettings.skybox = skybox;
       RenderSettings.fog = false;
    }
   }
}
