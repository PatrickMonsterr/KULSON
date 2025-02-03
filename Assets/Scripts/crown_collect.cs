using UnityEngine;

public class crown_collect : MonoBehaviour
{
    public GameObject crown;
    public end end;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kula")) 
        {

            Destroy(crown);
            end.crown_collected = true;
        }
    }


}
