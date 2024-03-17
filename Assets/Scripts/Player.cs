using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Kuþun uçmasý için bir kuvvete ihtiyacým var.

    public float kuvvet;  // public olduðu için editör üzerinden istediðim deðeri sonra verebilirim, deðiþtirebilirim.
    private Rigidbody2D rb;     // Kodda bulunan rigidbody'i bul, rb kýsaltmasýna bunu eþitle.

    public GameManager gameManager;

    public GameObject Death; // Sadece öldüðümüzde butonlarýn açýlmasýný istiyorum. // Ölme ekraný

    
    // Obje sahneye geldiði an bir kez çalýþýr.
    void Start()
    {
        Time.timeScale = 1f; // Zaman durduðunda zamaný 1 e eþitle tekrar zaman aksýn
        
        rb = GetComponent<Rigidbody2D>(); // Referans için oluþturuldu. rb deðiþkeninde deðiþiklik yaptýðýmda bu objenin RigidBodysinde deðiþiklik yapacaðým.
    }

    // Aldýðýmýz kare sayýsý boyunca çalýþýr
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * kuvvet;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)  // Trigger
    {
        // Eðer görünmez collider tetiklenirse bu fonksiyonu çalýþtýr. Kuþun borularýn arasýndan geçtiðini anlama ve skoru arttýrmak için.

        if (collision.gameObject.name == "Score")    // GameManager'daki fonksiyonu çalýþtýracaktýk Bunu yapmadan önce GameManager'ý Player'da tanýttým.
        {
            gameManager.UpdateScore();  // Borularda deðiþiklik yaptýk unityde bütün prefablere tanýmlanmasý için overide yapýyorum
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Çarpýþma olduðunda çalýþtýr - Neyle çarpýþtýrmalýyým?
    
        //Önce bize zararlý objelere bir tag eklemeliyim. (Etiket)
    
    {
        if (collision.gameObject.tag == "Engel")
        {

            Time.timeScale = 0f;  // Oyunun zamanýný 0 yap. Yani oyun dursun. Basit bir þekilde öldüðü belli olsun.

            Death.SetActive(true); // Engele çarptýðý zaman Deadth adlý GameObjecti görünür yapar. Player üzerinden hangi screenin Deadth olduðunu göster
        }
    }
}
