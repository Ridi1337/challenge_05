using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    private float currentTime;
    [SerializeField] private float wait;
    private bool fire, waiting;
    [SerializeField] private GameObject ammo;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        fire = Input.GetKey(KeyCode.Space);
        if (currentTime <= wait)
        {
            currentTime += 1f * Time.deltaTime;
            waiting = true;
        }
        if (currentTime >= wait)
        {
            currentTime = 0f;
            waiting = false;
        }
        if (fire && !waiting)
        {
            GameObject am = Instantiate(ammo.gameObject, transform.position, Quaternion.Euler(transform.up));
            am.transform.rotation = transform.rotation;
            audioSource.Play();
        }
    }
}
