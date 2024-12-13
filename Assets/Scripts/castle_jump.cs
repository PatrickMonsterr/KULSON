using Unity.VisualScripting;
using UnityEngine;

public class castle_jump : MonoBehaviour
{
    [SerializeField]
    public GameObject wall1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Kula"))
        {
            
            Destroy(wall1);
            
        }
    }
    
}
