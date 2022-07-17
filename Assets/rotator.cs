using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField] float _degreesPerSecond = 30f;
    [SerializeField] Vector3 _axis = Vector3.forward;
    void Update()
    {
        transform.Rotate(_axis.normalized * _degreesPerSecond * Time.deltaTime);
    }

}

