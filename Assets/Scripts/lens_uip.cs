using Unity.Cinemachine;
using UnityEngine;

public class lens_uip : MonoBehaviour
{
    public CinemachineCamera cam;
    float lensSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Kula"))
        {
            if(cam.Lens.FieldOfView < 60.5f)
            {
                cam.Lens.FieldOfView += lensSpeed * Time.deltaTime;
            }

        }
        
    }
}
