using UnityEngine;

public class Prison_Doors_Open : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator animator;

    public string trigger = "Dotyk";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kula"))
        {
            Debug.Log("Dziala");
            animator.SetTrigger(trigger);
        }
    }




    public void StopAnimator()
    {
        animator.enabled = false;
    }
}
