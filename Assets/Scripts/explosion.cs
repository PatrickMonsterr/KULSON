using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class explosion : MonoBehaviour
{
    public float explosionForce = 10f;
    public float explosionRadius = 5f;
    public float upwardsModifier = 0.5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kula"))
        {
            Explode();
        }
    }

    private void Explode()
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        Transform[] children = GetComponentsInChildren<Transform>();

        foreach (Rigidbody rb in rigidbodies)
        {
            if (rb != null)
            {
                rb.isKinematic = false;
                Vector3 explosionDirection = rb.transform.position - transform.position;


                // rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier);
            }
        }
        gameObject.GetComponent<Collider>().enabled = false;

        // foreach (Transform el in children)
        // {
        //     Destroy(el.gameObject);


        // }
        // for (int i = 1; i < children.Length; i++)
        // {
        //     Destroy(children[i].gameObject);
        //     StartCoroutine(WaitAndPrint());
        //     Debug.Log("TY KURWO");
        // }
        StartCoroutine(WaitAndPrint());






    }

     private IEnumerator WaitAndPrint()
{
    Transform[] children = GetComponentsInChildren<Transform>();
    Debug.Log("3 sekundy minęły!");
    // Wstrzymaj na 3 sekundy
    yield return new WaitForSeconds(3f);
    for (int i = 1; i < children.Length; i++)
        {
            Destroy(children[i].gameObject);
            yield return new WaitForSeconds(0.05f);
            Debug.Log("TY KURWO");
        }
      // Czas oczekiwania 3 sekundy

    // Po upływie 3 sekund wykonaj akcję
    Debug.Log("Akcja po 3 sekundach.");
}



}
