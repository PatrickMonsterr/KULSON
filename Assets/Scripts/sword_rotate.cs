using UnityEngine;

public class sword_rotate : MonoBehaviour
{
    public GameObject sword;
    float rotationSpeed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sword.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
