using UnityEngine;

public class krew : MonoBehaviour
{
    public ParticleSystem kreww;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("miecz"))
        {
           Debug.Log("kolizja dziala");
           kreww.Play();
           
        }
    }
}
