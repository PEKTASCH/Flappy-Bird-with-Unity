using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Ku�un u�mas� i�in bir kuvvete ihtiyac�m var.

    public float kuvvet;  // public oldu�u i�in edit�r �zerinden istedi�im de�eri sonra verebilirim, de�i�tirebilirim.
    private Rigidbody2D rb;     // Kodda bulunan rigidbody'i bul, rb k�saltmas�na bunu e�itle.

    public GameManager gameManager;

    public GameObject Death; // Sadece �ld���m�zde butonlar�n a��lmas�n� istiyorum. // �lme ekran�

    
    // Obje sahneye geldi�i an bir kez �al���r.
    void Start()
    {
        Time.timeScale = 1f; // Zaman durdu�unda zaman� 1 e e�itle tekrar zaman aks�n
        
        rb = GetComponent<Rigidbody2D>(); // Referans i�in olu�turuldu. rb de�i�keninde de�i�iklik yapt���mda bu objenin RigidBodysinde de�i�iklik yapaca��m.
    }

    // Ald���m�z kare say�s� boyunca �al���r
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * kuvvet;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)  // Trigger
    {
        // E�er g�r�nmez collider tetiklenirse bu fonksiyonu �al��t�r. Ku�un borular�n aras�ndan ge�ti�ini anlama ve skoru artt�rmak i�in.

        if (collision.gameObject.name == "Score")    // GameManager'daki fonksiyonu �al��t�racakt�k Bunu yapmadan �nce GameManager'� Player'da tan�tt�m.
        {
            gameManager.UpdateScore();  // Borularda de�i�iklik yapt�k unityde b�t�n prefablere tan�mlanmas� i�in overide yap�yorum
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // �arp��ma oldu�unda �al��t�r - Neyle �arp��t�rmal�y�m?
    
        //�nce bize zararl� objelere bir tag eklemeliyim. (Etiket)
    
    {
        if (collision.gameObject.tag == "Engel")
        {

            Time.timeScale = 0f;  // Oyunun zaman�n� 0 yap. Yani oyun dursun. Basit bir �ekilde �ld��� belli olsun.

            Death.SetActive(true); // Engele �arpt��� zaman Deadth adl� GameObjecti g�r�n�r yapar. Player �zerinden hangi screenin Deadth oldu�unu g�ster
        }
    }
}
