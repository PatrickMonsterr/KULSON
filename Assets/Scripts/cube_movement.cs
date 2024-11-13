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
    public float maxJumpForce = 5f;
    public float chargeRate = 2f;

    private float jumpCharge = 0f;
    private bool isCharging = false;


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
            isGrounded = false;
           isCharging = true;
           jumpCharge = 0f;
            //rb.AddForce(Vector3.up * power, ForceMode.Impulse);
            //isGrounded = false; 
        }

        if (isCharging)
        {
            jumpCharge += chargeRate * Time.deltaTime;
            jumpCharge = Mathf.Clamp(jumpCharge, 0, maxJumpForce); // ograniczenie do maksymalnej sily
            Debug.Log(jumpCharge);
        }

        if(Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            rb.AddForce(Vector3.up * jumpCharge, ForceMode.Impulse);
            isCharging = false;
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