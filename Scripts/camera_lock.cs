using UnityEngine;

public class camera_lock : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position;
    }

    
    void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
    }
}
