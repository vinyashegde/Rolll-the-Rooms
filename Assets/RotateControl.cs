using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    public Rigidbody playerRigid;
    public rotator rotate;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        StartCoroutine(ExampleCoroutine());
        rotate.GetComponent<rotator>();
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(10);
        rotate.GetComponent<rotator>().enabled = true;
        //Remove all constraints
        //playerRigid.constraints = RigidbodyConstraints.None;


        yield return new WaitForSeconds(10);
        rotate.GetComponent<rotator>().enabled = false;
        //This locks the RigidBody so that it does not move or rotate in the Z axis.
        //playerRigid.constraints = RigidbodyConstraints.FreezeRotationX & RigidbodyConstraints.FreezeRotationY & RigidbodyConstraints.FreezeRotationZ;

        yield return new WaitForSeconds(10);
        StartCoroutine(ExampleCoroutine());

    }
}
