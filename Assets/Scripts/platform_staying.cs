using NUnit.Framework.Constraints;
using UnityEditor.Callbacks;
using UnityEngine;

public class platform_staying : MonoBehaviour
{
    public cube_movement kulka;
    void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kula")
        {
            Debug.Log("DZIALA XD");
            other.transform.parent = transform;
            //kulka.rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Kula")
        {
             other.transform.parent = null;
            //kulka.rb.constraints = RigidbodyConstraints.None;
        }
    }



}
