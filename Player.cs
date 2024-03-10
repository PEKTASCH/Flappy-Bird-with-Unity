using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float kuvvet = 1f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()   // Obje sahnede olusturuldugu an bir kez calisir.
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()    // Frame per second her zaman calisacak
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * kuvvet;
        }
    }
}
