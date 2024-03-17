using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borular : MonoBehaviour
{

    public float hiz; // Borular�n hangi h�zda gelmesi i�in bir de�i�ken olu�turdum

    private void Start()
    {
        Destroy(gameObject,10); // Start oldu�unda bu objeyi 10 sn yok et.
    }

    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime; // �uanki pozisyonuna ekleme yap    Delta time: Bunu da zamana g�re yap
    }
}

