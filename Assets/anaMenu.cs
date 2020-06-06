using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class anaMenu : MonoBehaviour
{
    public Text puanText;
    public Text puan;

    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("enYuksekPuanKayit");
        int puanGelen = PlayerPrefs.GetInt("puanKayit");

        puanText.text = "En Yuksek Puan " + enYuksekPuan;
        puan.text = "Puan =" + puanGelen;


    }

    
    void Update()
    {
        
    }

    public void OyunaGit()
    {
        SceneManager.LoadScene("level");
    }
    public void OyundanCik()
    {
        Application.Quit();
    }


}
