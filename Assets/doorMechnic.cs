using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorMechnic : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                Debug.Log("Pressed");
                myDoor.Play(doorOpen, 0, 0.0f);
                //gameObject.SetActive(false);
            }
            /*
            else if (closeTrigger)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    myDoor.Play(doorClose, 0, 0.0f);
                    gameObject.SetActive(false);
                }
                
            }
            */
        }
    }

    private void OnTriggerExit(Collider other)
    {
        myDoor.Play(doorClose, 0, 0.0f);
        //gameObject.SetActive(false);
    }
}    
