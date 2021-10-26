using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource _ding;

    void Start()
    {
       _ding = GetComponent<AudioSource>();
       GetComponent<AudioSource>().playOnAwake = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        _ding.Play();
    }
}