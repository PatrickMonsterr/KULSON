using UnityEngine;

public class platform_staying : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kula")
        {
            Debug.Log("DZIALA XD");
            other.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Kula")
        {
            other.transform.parent = null;
        }
    }



}
