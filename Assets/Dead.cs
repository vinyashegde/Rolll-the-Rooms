using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject deadText;
    public GameObject PressR;
    public GameObject iamDone;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            deadText.SetActive(true);
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
        deadText.SetActive(false);
        PressR.SetActive(true);
        yield return new WaitForSeconds(15);
        PressR.SetActive(false);
        iamDone.SetActive(true);
    }
}
