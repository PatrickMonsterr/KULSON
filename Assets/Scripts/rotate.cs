using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class rotate : MonoBehaviour
{
    public GameObject sword;
    public Animator animator;
    [SerializeField]
    float rotationSpeed = 50f;
    public Rigidbody gracz;
    public GameObject king;


    void Start()
    {
        animator.enabled = false;
    }


    void Update()
    {
        //Debug.Log($"Y: {Y}");
        //sword.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Kula") && (Input.GetKeyDown(KeyCode.F)))
        {
            Debug.Log("dziala");
            animator.enabled = true;
            animator.SetTrigger("dotyk");
            gracz.isKinematic = true;


        }

    }



    
}
    

