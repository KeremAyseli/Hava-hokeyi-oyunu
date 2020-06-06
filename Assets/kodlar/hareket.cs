using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public GameObject karakter2;
    public float hız;
    public Rigidbody2D rigibod;
    public Collider2D sınır;
    public static float ilk_baslangıc_karakter_x, ilk_baslangıc_karakter_y;
    public Joystick joystick;
    public Joystick joystick2;
    public static float top_hız;
    public Collider2D top_sınır;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        ilk_baslangıc_karakter_x = karakter2.transform.position.x;
        ilk_baslangıc_karakter_y = karakter2.transform.position.y;
        Debug.Log(ilk_baslangıc_karakter_x + "" + ilk_baslangıc_karakter_y);
        rigibod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hız =500;
        //Bilgisayar da yaptığım testler sırasında kullandığım tuş kodları.
        /*rigibod.AddForce(transform.forward * hız);
        if (Input.GetKey(KeyCode.D))
        {
            rigibod.velocity = Vector2.right * hız * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigibod.velocity = Vector2.left * hız * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigibod.velocity = Vector2.up * hız * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigibod.velocity = Vector2.down * hız * Time.deltaTime;
        }*/
       rigibod.velocity = new  Vector2(joystick.Horizontal * hız*Time.deltaTime, joystick.Vertical *hız*Time.deltaTime);

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {top_hız = 400;
            if (gameObject.name == "karakter_2")
            {yapay_zeka.top_baslangıc_konum = true;
              
                collision.attachedRigidbody.AddForce(Vector2.right * hız);
                 collision.attachedRigidbody.AddForce(new Vector2(joystick2.Horizontal*hız, joystick2.Vertical*hız));
                top_sınır.isTrigger = false;
            }
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.D))
            {
                hız = 100;
                collision.attachedRigidbody.AddForce(Vector2.right * hız);
                 collision.attachedRigidbody.AddForce(Vector2.up * hız);
               
            }
            
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
            if (gameObject.name == "karakter_2")
            {
                top_sınır.isTrigger = true;
                hız = 1000;
                collision.attachedRigidbody.AddForce(Vector2.right * hız);
               // Debug.Log("1");
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
            if (gameObject.name == "karakter_2")
            {
                top_sınır.isTrigger =false;
            }
        }
    }
}
