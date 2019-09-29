using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuş_basma : MonoBehaviour
{
    public Button btn_yukarı;
    public Button btn_asagı;
    public Button btn_sag;
    public Button btn_sol;
    public GameObject karakter_1;
    public Rigidbody2D rigidbody_karakter;
    public float hız4;
    // Start is called before the first frame update
    void Start()
    {
        hız4 = 100;
      
    }

   public void Bttn_yukarı(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
                hız4 = 100;
                collision.attachedRigidbody.AddForce(Vector2.right * hız4);
                collision.attachedRigidbody.AddForce(Vector2.up * hız4);
        }
    }
    public void Bttn_asagı(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
                hız4 = 100;
                collision.attachedRigidbody.AddForce(Vector2.right * hız4);
                collision.attachedRigidbody.AddForce(Vector2.up * hız4);}
    }
    
}
