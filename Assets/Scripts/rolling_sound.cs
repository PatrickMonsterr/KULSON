using UnityEngine;

public class rolling_sound : MonoBehaviour
{
    public AudioSource impactSound;
    public AudioSource bounce;
    public float impactThreshold = .5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (collision.relativeVelocity.magnitude > impactThreshold)
            {
                impactSound.Play();
            }
        }

        if (collision.gameObject.CompareTag("Grzyb"))
        {
            if (collision.relativeVelocity.magnitude > impactThreshold)
            {
                bounce.Play();
            }
        }
        
    }


}
