using UnityEngine;

public class Leaf_jump_real : MonoBehaviour
{

    public cube_movement kula_move;
    public Animator bump;
    private float odbicie = 20f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            bump.SetTrigger("Bump");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kula"))
        {
            Debug.Log("przed triggerem");
            bump.SetTrigger("Bump");




        }





    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Kula"))
        {
             bump.SetTrigger("Bump");

            kula_move.rb.AddForce(Vector3.up * odbicie, ForceMode.Impulse);


            if (odbicie < 60)
            {
                odbicie += 20f;
            }
            Debug.Log(odbicie);
        }
    }
    public void ResetOdbicie()
    {
        odbicie = 20f;
    }

}
