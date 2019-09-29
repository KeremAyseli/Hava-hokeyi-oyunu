using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saha : MonoBehaviour
{
    public Collider2D sınır;
    public bool sınır_kontrol;
    public Text skor_yapay_zeka_yazı;
    public Text skor_karakter_yazı;
    public int skor_karakter;
    public int skor_yapay_zeka;
    public GameObject yapay_zeka1;
    public GameObject karakter;
    public GameObject top1;
    public float hız3;
    public SpriteRenderer saharenk;
    private void Start()
    {
        skor_karakter = 0;
        skor_yapay_zeka = 0;
    }
    void baslama_yerine_dön()
    {
        hız3 = 100;
        karakter.transform.position = new Vector2(hareket.ilk_baslangıc_karakter_x, hareket.ilk_baslangıc_karakter_y);
        yapay_zeka1.transform.position = new Vector2(yapay_zeka.ilk_baslangıc_x_yapay_zeka,yapay_zeka.ilk_baslangıc_y_yapay_zeka);
        top1.transform.position = new Vector2(top.top_baslangıc_x, top.top_baslangıc_y);
        System.Random rnd = new System.Random();
        int rastgele = rnd.Next(0, 100);
        if(rastgele%2==0)
        {
            top.rigibod2.velocity = Vector2.right * hız3 * Time.deltaTime;
        }
        else
        {
            top.rigibod2.velocity = Vector2.left * hız3 * Time.deltaTime;
        }
    }
    System.Random rastgele = new System.Random();
       
       public float randomR;
       public  float randomG;
       public float randomB;
    private void Update()
    {
        
        
        
       
        if (top1.transform.position.x > yapay_zeka1.transform.position.x)
        {
            skor_karakter++;
            skor_karakter_yazı.text = skor_karakter.ToString();
            baslama_yerine_dön();
           
        }
        if (top1.transform.position.x < karakter.transform.position.x)
        {
            skor_yapay_zeka++;
            skor_yapay_zeka_yazı.text = skor_yapay_zeka.ToString();
            baslama_yerine_dön();
           
        }
 for (int i=0;i<1;i++)
        {   
            randomR = rastgele.Next(100, 255);
            randomG = rastgele.Next(100, 255);
            randomB = rastgele.Next(100, 255);
            
            saharenk.color = new Color(randomR, randomG, randomB);
        }
        

    }
    

}
