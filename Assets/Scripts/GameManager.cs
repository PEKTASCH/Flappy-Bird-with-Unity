using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; //
using UnityEngine.SceneManagement;  // Unity fonksiyonu (Yeniden ba�lama)
// Game Manager �zerinde oyuncunun skorunu kaydedece�im.
public class GameManager : MonoBehaviour
{
    public int Score;

    public TMP_Text ScoreText;

    void Start()
    {
        Score = 0; // Start durumunda 0 olsun.
        ScoreText.text = Score.ToString(); // �nce say�sal Score de�i�kenini stringe �evir sonra Scoretext'e e�itle
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString(); // her start oldu�unda e�itliyecek her artt���nda da e�itlemek istiyorum.
    }

    public void RestartGame()  // E�er restart game fonksiyonu �al���rsa 0. sahneyi y�kle  // File - Build settings
    {
        SceneManager.LoadScene(0);
    }
}

//Game Manager olu�turdu�um Score textini hen�z g�rm�yor. �nce text k�t�phanesini belirtmem gerekiyor.
