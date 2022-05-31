using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCollect : MonoBehaviour
{
    public Text text;
    private int score = 0;

    private void Start()
    {
        
    }
    private void Update()
    {
        Debug.Log(score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.collider.tag == "Coin")
        {
            Destroy(collision.gameObject);
            score = score + 5;
            text.text = score.ToString();
            
        }

        if (collision.collider.tag == "Meto")
        {
            Destroy(collision.gameObject);
            score = score - 1;
            text.text = score.ToString();

        }
    }


}
