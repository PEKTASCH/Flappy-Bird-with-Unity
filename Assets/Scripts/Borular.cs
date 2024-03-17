using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borular : MonoBehaviour
{

    public float hiz; // Borularýn hangi hýzda gelmesi için bir deðiþken oluþturdum

    private void Start()
    {
        Destroy(gameObject,10); // Start olduðunda bu objeyi 10 sn yok et.
    }

    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime; // Þuanki pozisyonuna ekleme yap    Delta time: Bunu da zamana göre yap
    }
}

