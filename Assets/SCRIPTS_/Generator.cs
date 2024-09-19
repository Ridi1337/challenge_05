using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject[] asteroids;
    public AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        System.Random r = new System.Random();
        for (int i = 0; i < 1000; i++)
        {
            if (i % 5 == 0)
            {
                for (int obj = 0; obj <= asteroids.Length - 1; obj++)
                {
                    Point point = Instantiate(asteroids[obj].gameObject, new Vector2(r.Next(-100, 100), r.Next(-100, 100)), Quaternion.identity).GetComponent<Point>();
                    point.OnAsteroidDestroy += PlayAsteroidExplosionSound;
                    point.OnAsteroidDestroy += PlayAsteroydExplosionParticle;
                }
            }

        }
    }

    private void PlayAsteroidExplosionSound()
        => audioSource.Play();

    private void PlayAsteroydExplosionParticle()
        => Debug.Log("BOOM EFFECT!");
}
