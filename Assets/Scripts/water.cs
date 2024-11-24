using UnityEngine;

public class water : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float drag = 2f;       // Siła oporu cieczy
    public float buoyancy = 10f; // Siła wyporu

    void OnTriggerStay(Collider other)
    {
        // Upewnij się, że obiekt ma Rigidbody
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Opór cieczy
            Vector3 velocity = rb.linearVelocity;
            rb.AddForce(-velocity * drag);

            // Siła wyporu (symulacja pływalności)
            if (other.transform.position.y < transform.position.y) // Jeśli obiekt zanurzony
            {
                rb.AddForce(Vector3.up * buoyancy);
            }
        }
    }
}
