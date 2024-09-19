using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoFly : MonoBehaviour
{
    
    [SerializeField] private float speed;
    private float waiting = 4f, time;

    // Update is called once per frame
    void Update()
    {
        time+=1f*Time.deltaTime;
        if (time>=waiting){
            Destroy(gameObject);
        }
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
