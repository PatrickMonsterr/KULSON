using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outro : MonoBehaviour
{
    public TextMeshProUGUI outroo;
    void Start()
    {
        StartCoroutine(DisplayText());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DisplayText()
    {
        Debug.Log("DZIAL?? XD");
        yield return new WaitForSeconds(2f);
        outroo.text = "KULSON";
        yield return new WaitForSeconds(2f);
        outroo.text = "MADE BY PATRYK";
        yield return new WaitForSeconds(2f);
        outroo.text = "THANKS TO ALEK AND KUBA FOR IDEAS AND FEEDBACK";
        yield return new WaitForSeconds(2f);
        outroo.text = ": D";
 

        yield return new WaitForSeconds(10f);
        SceneManager.LoadSceneAsync("MENU");
    }
}
