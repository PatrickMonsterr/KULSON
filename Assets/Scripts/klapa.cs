using UnityEngine;

public class klapa : MonoBehaviour
{
    public Animator klapaa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kula"))
        {
            klapaa.SetTrigger("klapa");
        }
    }
}
