using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yapay_zeka_alan : MonoBehaviour
{
   public GameObject alan;
    public Collider2D sınır;
    public static bool kontrol;
    private void Start()
    {
        kontrol = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="top")
        {
            kontrol = true;
        }
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name=="top")
        {
            kontrol = false;
        }
    }

}
