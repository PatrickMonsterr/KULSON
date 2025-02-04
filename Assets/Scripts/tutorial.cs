using TMPro;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public TextMeshProUGUI tutoriall;
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
            tutoriall.text = "W,A,S,D - moving\r\n\r\nPRESS AND HOLD SPACE TO JUMP";
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Kula"))
        {
            tutoriall.text = "";
        }
           
    }
}
