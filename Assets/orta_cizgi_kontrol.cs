using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orta_cizgi_kontrol : MonoBehaviour
{
    public Collider2D orta_cizgi;
    public Rigidbody2D karakter_1, karakter_2;
    // Start is called before the first frame update
    void Start()
    {
        orta_cizgi.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(saha.kontrol==true)
        {
            orta_cizgi.isTrigger = true;
        }
       if(saha.kontrol==false)
        {
            orta_cizgi.isTrigger = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            if(collision.gameObject.name=="karakter_1")
            {
            karakter_1.AddForce(100f * Vector2.right);
            Debug.Log("güç uygulandı");
            }
            if(collision.gameObject.name=="karakter_2")
            {
            karakter_2.AddForce(1000f * Vector2.left);
            Debug.Log("güç uygulandı");
            }
            
        
        if (collision.gameObject.name == "karakter_1")
            {
            karakter_1.AddForce(100f * Vector2.right);
            Debug.Log("güç uygulandı");
            }
        if(collision.gameObject.name=="karakter_2")
            {
            karakter_2.AddForce(1000f * Vector2.left);
            Debug.Log("güç uygulandı");
            }
           
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
            if (collision.gameObject.name == "karakter_1")
            {
            karakter_1.AddForce(100f * Vector2.right);
                Debug.Log("güç uygulandı");
            }
            if (collision.gameObject.name == "karakter_2")
            {
            karakter_2.AddForce(1000f * Vector2.left);
                Debug.Log("güç uygulandı");
            }
            
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
            if (collision.gameObject.name == "karakter_1")
            {
                karakter_1.AddForce(100f * Vector2.right);
            }
            if (collision.gameObject.name == "karakter_2")
            {
                karakter_2.AddForce(100f * Vector2.left);
            }
        
    }

}
