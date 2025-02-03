using Unity.VisualScripting;
using UnityEngine;

public class player_stop : MonoBehaviour
{
    public GameObject king;
    public Rigidbody gracz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (king.IsDestroyed())
        {
            gracz.isKinematic = false;
        }
    }
}
