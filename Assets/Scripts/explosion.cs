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
                


                
            }
        }
        gameObject.GetComponent<Collider>().enabled = false;


        StartCoroutine(WaitAndPrint());






    }

     private IEnumerator WaitAndPrint()
{
    Transform[] children = GetComponentsInChildren<Transform>();
    Debug.Log("3 sekundy minęły!");

    yield return new WaitForSeconds(3f);
    for (int i = 1; i < children.Length; i++)
        {
            Destroy(children[i].gameObject);
            yield return new WaitForSeconds(0.05f);
            Debug.Log("TY KURWO");
        }
      

   
    Debug.Log("Akcja po 3 sekundach.");
}



}
