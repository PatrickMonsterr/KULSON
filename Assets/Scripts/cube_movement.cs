using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class cube_movement : MonoBehaviour
{
    [SerializeField]
    GameObject floor;
    [SerializeField]
    float speed = 5f;
    private Rigidbody rb;
    [SerializeField]
    float power = 5f;
    private bool isGrounded;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {

        if (Input.GetAxis("Horizontal") > 0) 
        {
            rb.AddForce(Vector3.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-Vector3.right * speed);
                
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.forward * speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(-Vector3.forward * speed);

        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
           
            rb.AddForce(Vector3.up * power, ForceMode.Impulse);
            isGrounded = false; 
        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            isGrounded =true;
        }
    }


}