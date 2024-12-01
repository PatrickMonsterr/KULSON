using UnityEngine;

public class pipe_boost : MonoBehaviour
{
    public cube_movement kula;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnTriggerEnter(Collider collision)
   {
    if(collision.gameObject.CompareTag("Kula"))
    {
        kula.rb.AddForce(Vector3.up * 110, ForceMode.Impulse);
    }
   }
}
