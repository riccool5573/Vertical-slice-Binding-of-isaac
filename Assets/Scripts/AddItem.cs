using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    private int keyCount;
    private int coinCount;
    private int bombCount;

    private void Start()
    {
        keyCount = 0;
        bombCount = 1;
        coinCount = 0;

        Debug.Log("Key Count = " + keyCount);
        Debug.Log("Coin Count = " + coinCount);
        Debug.Log("Bomb Count = " + bombCount);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Key")
        {
            keyCount = keyCount + 1;
            Debug.Log("Key Count = " + keyCount);
        }

        else if (col.gameObject.tag == "Coin")
        {
            coinCount = coinCount + 1;
            Debug.Log("Coin Count = " + coinCount);
        }

        else if (col.gameObject.tag == "Bomb")
        {
            bombCount = bombCount + 1;
            Debug.Log("Bomb Count = " + bombCount);
        }
    }
}
