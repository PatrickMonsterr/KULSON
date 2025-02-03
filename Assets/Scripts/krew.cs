using System.Collections;
using UnityEngine;

public class krew : MonoBehaviour
{
    public ParticleSystem kreww;
    public GameObject king;
    public Rigidbody rb_crown;
    public Rigidbody miecz;
    public Transform mieczT;
    public Animator animator;
    public GameObject mieczGO;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("miecz"))
        {
           Debug.Log("kolizja dziala");
           kreww.Play();
            StartCoroutine(king_dissapear());
            
           
        }
    }

    IEnumerator king_dissapear()
    {
        yield return new WaitForSeconds(1.5f);
        StopAnimation();
        miecz.isKinematic = false;
        rb_crown.isKinematic = false;

        StartCoroutine(znikanieMiecza()); 
        yield return new WaitForSeconds(1.5f);

        Destroy(king);
    }

    void StopAnimation()
    {
        animator.enabled = false;
        mieczT.position = mieczT.position;
    }

    IEnumerator znikanieMiecza()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy (mieczGO);
    }
}


