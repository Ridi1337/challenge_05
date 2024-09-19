using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject point;

    public event System.Action OnAsteroidDestroy = default;

    void Start(){
        point = GameObject.Find("CORE");
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ammo"){
            point.GetComponent<POINT1>().Add(1);
            OnAsteroidDestroy?.Invoke();

            Destroy(gameObject);
        }
    }
}
