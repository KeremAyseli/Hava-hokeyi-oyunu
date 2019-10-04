using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    public float hız2;
    public static Rigidbody2D rigibod2;
    public GameObject top2;
    System.Random rand = new System.Random();
    public static float top_baslangıc_x, top_baslangıc_y;
    // Start is called before the first frame update
    void Start()
    {
        top_baslangıc_x = top2.transform.position.x;
        top_baslangıc_y = top2.transform.position.y;
        Debug.Log(top_baslangıc_x + "" + top_baslangıc_y);
        rigibod2 = GetComponent<Rigidbody2D>();
        hız2 = 100;
        int x = rand.Next(0, 100);
        if (x % 2 == 0)
        {
            rigibod2.velocity = Vector2.right * hız2 * Time.deltaTime;
        }
        else
        {
            rigibod2.velocity = Vector2.left * hız2 * Time.deltaTime;
        }
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
