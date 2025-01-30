using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject sword;
    public Animator animacja;
    public Animator animator;
    [SerializeField]
    float rotationSpeed = 50f;
    
    
    void Start()
    {
       animacja.enabled = false;    
    }

    
    void Update()
    {
        //Debug.Log($"Y: {Y}");
        sword.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kula"))
        {
            animacja.enabled=true;
            animator.SetTrigger("dotyk");
        }
    }
}
