using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; //
using UnityEngine.SceneManagement;  // Unity fonksiyonu (Yeniden baþlama)
// Game Manager üzerinde oyuncunun skorunu kaydedeceðim.
public class GameManager : MonoBehaviour
{
    public int Score;

    public TMP_Text ScoreText;

    void Start()
    {
        Score = 0; // Start durumunda 0 olsun.
        ScoreText.text = Score.ToString(); // Önce sayýsal Score deðiþkenini stringe çevir sonra Scoretext'e eþitle
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString(); // her start olduðunda eþitliyecek her arttýðýnda da eþitlemek istiyorum.
    }

    public void RestartGame()  // Eðer restart game fonksiyonu çalýþýrsa 0. sahneyi yükle  // File - Build settings
    {
        SceneManager.LoadScene(0);
    }
}

//Game Manager oluþturduðum Score textini henüz görmüyor. Önce text kütüphanesini belirtmem gerekiyor.
