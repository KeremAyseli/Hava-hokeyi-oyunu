using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baslangıc_alan_ayarlama : MonoBehaviour
{
   public Camera kamere;
    public SpriteRenderer alan;
    // Start is called before the first frame update
    void Start()
    {
        float alan_hesaplama = alan.bounds.size.x * Screen.height / Screen.width * 1f;
       kamere.orthographicSize = alan_hesaplama;
    }

   
}
