using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class cube_movement : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    private Rigidbody rb;


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




    }


}