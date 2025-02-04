using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class presstokill : MonoBehaviour
{
    public TextMeshProUGUI kingKill;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Kula"))
        {
            kingKill.text = "Press F to kill your father";
        }

        if (collision.gameObject.CompareTag("Kula") && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(kingKill);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Kula"))
        {
            kingKill.text = "";
        }
    }


}
