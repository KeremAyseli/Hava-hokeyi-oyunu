using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class yapay_zeka : MonoBehaviour
{
    public float hız2;
    public Rigidbody2D rigidbod1;
    public GameObject top;
    public GameObject karakter_1;
    public GameObject karakter_2;
    public Collider2D sınır2;
    public double konum_eksiy;
    public double konum_artıy;
    public float baslangıc_x,baslangıc_y;
    public static float ilk_baslangıc_x_yapay_zeka, ilk_baslangıc_y_yapay_zeka;
    double artıy = 5.64;
    double eksiy = -4.53;
    // Start is called before the first frame update
    void Start()
    {
        ilk_baslangıc_x_yapay_zeka = karakter_1.transform.position.x;
        ilk_baslangıc_y_yapay_zeka = karakter_1.transform.position.y;
        Debug.Log(ilk_baslangıc_x_yapay_zeka + "" + ilk_baslangıc_y_yapay_zeka);
        rigidbod1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hız2 = 100;
        if (yapay_zeka_alan.kontrol == true)
        {
            if (karakter_1.transform.position.y < top.transform.position.y)
            {
                rigidbod1.velocity = Vector2.up * hız2 * Time.deltaTime;
            }
            if (karakter_1.transform.position.y > top.transform.position.y)
            {
                rigidbod1.velocity = Vector2.down * hız2 * Time.deltaTime;
            }
            if (karakter_1.transform.position.x > top.transform.position.x)
            {
                rigidbod1.velocity = Vector2.left * hız2 * Time.deltaTime;
            }
            if (karakter_1.transform.position.x < top.transform.position.x)
            {
                rigidbod1.velocity = Vector2.right * hız2 * Time.deltaTime;
            }
            if(karakter_1.transform.position.y==top.transform.position.y|| karakter_1.transform.position.y < top.transform.position.y)
            {
                hız2 = 150;
                rigidbod1.velocity = Vector2.up * hız2 * Time.deltaTime;
            }
            if(karakter_1.transform.position.y==top.transform.position.y|| karakter_1.transform.position.y > top.transform.position.y)
            {
                hız2 = 150;
                rigidbod1.velocity = Vector2.down * hız2 * Time.deltaTime;
            }
            if (karakter_1.transform.position.x == top.transform.position.x || karakter_1.transform.position.x < top.transform.position.x)
            {
                hız2 = 150;
                rigidbod1.velocity = Vector2.left * hız2 * Time.deltaTime;
            }
            if ( karakter_1.transform.position.x < top.transform.position.x&&  karakter_1.transform.position.y < top.transform.position.y)
            {
                hız2 = 200;
                rigidbod1.velocity = new Vector2(1*hız2*Time.deltaTime, 1*hız2*Time.deltaTime);
            }
            if ( karakter_1.transform.position.x > top.transform.position.x &&  karakter_1.transform.position.y < top.transform.position.y)
            {
                hız2 = 200;
                rigidbod1.velocity = new Vector2(-1 * hız2 * Time.deltaTime, 1 * hız2 * Time.deltaTime);
            }
            if (karakter_1.transform.position.x > top.transform.position.x && karakter_1.transform.position.y > top.transform.position.y)
            {
                hız2 = 200;
                rigidbod1.velocity = new Vector2(-1 * hız2 * Time.deltaTime, -1 * hız2 * Time.deltaTime);
            }
            if (karakter_1.transform.position.x < top.transform.position.x && karakter_1.transform.position.y > top.transform.position.y)
            {
                hız2 = 200;
                rigidbod1.velocity = new Vector2(1 * hız2 * Time.deltaTime, -1 * hız2 * Time.deltaTime);
            }
            Debug.Log("top_alanda");
            //
            konum_artıy = karakter_2.transform.position.y - artıy;
            konum_eksiy = karakter_2.transform.position.y - eksiy;
            
        }
  else  if(yapay_zeka_alan.kontrol==false)
        {
            baslangıc_x = top.transform.position.x - 1;
            baslangıc_y = top.transform.position.y - 1;
            if (baslangıc_x<karakter_1.transform.position.x)
            {
                hız2 = 300;
                rigidbod1.velocity = new Vector2(1 * hız2 * Time.deltaTime, 1);
                Debug.Log("ileri gidildi");
            }
            if (baslangıc_x > karakter_1.transform.position.x)
            {
                hız2 = 300;
                rigidbod1.velocity = new Vector2(-1 * hız2 * Time.deltaTime,1);
                Debug.Log("geri gidildi");
            }
            if(baslangıc_y<karakter_1.transform.position.y)
            {
                hız2 = 100;
                rigidbod1.velocity = new Vector2(1, -1 * hız2 * Time.deltaTime);
            }
            if(baslangıc_y>karakter_1.transform.position.y)
            {
                hız2 = 100;
                rigidbod1.velocity = new Vector2(1, 1 * hız2 * Time.deltaTime);
            }
            Debug.Log(baslangıc_x + " " + baslangıc_y);
            Debug.Log("alanda top yok2");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
            if (gameObject.name == "karakter_1")
            {hız2 = 150;
                if (konum_artıy < konum_eksiy)
                {
                    Debug.Log("yukarı");
                    
                collision.attachedRigidbody.AddForce(Vector2.left * hız2);
                    collision.attachedRigidbody.AddForce(Vector2.up * hız2);
                }
                if(konum_eksiy>konum_artıy)
                {
                    Debug.Log("aşağı");
                    collision.attachedRigidbody.AddForce(Vector2.left * hız2);
                    collision.attachedRigidbody.AddForce(Vector2.down * hız2);
                }
                
                Debug.Log("2");
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name=="top")
        {
            if(gameObject.name=="karakter_1")
            {
                hız2 = 150;
                collision.attachedRigidbody.AddForce(Vector2.left * hız2);
                Debug.Log("2");
            }
        }
    }
}
