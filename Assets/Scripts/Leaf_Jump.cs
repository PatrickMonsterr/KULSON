using UnityEngine;

public class Leaf_Jump : MonoBehaviour
{
    
    [SerializeField]
    private GameObject platform;
    [SerializeField]
    private GameObject barier;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kula"))
        {
            platform.SetActive(false);
            barier.SetActive(false);
        }
    }



}
