using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private Vector3 offset;
    private float speed = 1.0f;


    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, speed);
    }
}
