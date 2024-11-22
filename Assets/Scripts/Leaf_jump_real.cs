using UnityEngine;

public class Leaf_jump_real : MonoBehaviour
{
    public cube_movement kula_move;
    private float odbicie = 20f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kula"))
        {
            kula_move.rb.AddForce(Vector3.up * odbicie, ForceMode.Impulse);
            odbicie += 20f;
        }
    }

}
