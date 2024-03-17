using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Borular;
    
    public float yukseklik;
    public float SpawnHiz;
    
    void Start()
    {
        StartCoroutine(SpawnObject(SpawnHiz));
    }

    
    public IEnumerator SpawnObject(float time) // void update yerine Unity'nin �zel fonksiyonunu kullan�yorum. Zamanla �al��an i�lemler yapabilirim.
    {
        while (true) // tekrarl� bir �ekilde borular� spawn etmek i�in while d�ng�s� kullan�yorum
        {

            Instantiate(Borular, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity); // de�i�ken pay� -y�kseklik, +y�kseklik. A��s� da ba�lang��taki a��s�
            yield return new WaitForSeconds(time); // Bu time boyunca bunu tekrarla

        }
    
        
    }
}
