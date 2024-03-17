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

    
    public IEnumerator SpawnObject(float time) // void update yerine Unity'nin özel fonksiyonunu kullanýyorum. Zamanla çalýþan iþlemler yapabilirim.
    {
        while (true) // tekrarlý bir þekilde borularý spawn etmek için while döngüsü kullanýyorum
        {

            Instantiate(Borular, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity); // deðiþken payý -yükseklik, +yükseklik. Açýsý da baþlangýçtaki açýsý
            yield return new WaitForSeconds(time); // Bu time boyunca bunu tekrarla

        }
    
        
    }
}
